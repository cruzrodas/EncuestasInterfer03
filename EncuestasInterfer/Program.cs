using EncuestasInterfer.BioTime;
using EncuestasInterfer.BioTimeSQL;
using EncuestasInterfer.Components;
using EncuestasInterfer.Models;
using EncuestasInterfer.Services.AnalisisEncuestaServices;
using EncuestasInterfer.Services.AsistenciaServices;
using EncuestasInterfer.Services.DepartamentoService;
using EncuestasInterfer.Services.DepartamentoServices;
using EncuestasInterfer.Services.EncuestaServices;
using EncuestasInterfer.Services.EncuestasServices;
using   EncuestasInterfer.Services.GeneroServices;
using EncuestasInterfer.Services.MunicipioServices;
using EncuestasInterfer.Services.NacionalidadServices;
using EncuestasInterfer.Services.OpcionRespuestaCondicionService;
using EncuestasInterfer.Services.OpcionRespuestaServices;
using EncuestasInterfer.Services.PreguntasServices;
using EncuestasInterfer.Services.RespuestaDetalleServices;
using EncuestasInterfer.Services.RespuestaEncuestaService;
using EncuestasInterfer.Services.RespuestaEncuestaServices;
using EncuestasInterfer.Services.RespuestaMultipleServices;
using EncuestasInterfer.Services.TipoIdentificacionService;
using EncuestasInterfer.Services.TipoIdentificacionServices;
using EncuestasInterfer.Services.TipoPreguntaServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MudBlazor.Services;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddTransient<IGeneroServices, SGeneroServices>();
builder.Services.AddTransient<INacionalidadService, SNacionalidadServices>();
builder.Services.AddTransient<IDepartamenteServices, SDepartamentoServices>();
builder.Services.AddTransient<IMunicipioServices, SMunicipioServices>();
builder.Services.AddTransient<ITipoIdentificacionServices, STipoIdentificacionServices>();
builder.Services.AddTransient<IEncuestaServices, SEncuestaServices>();
builder.Services.AddTransient<ITipoPreguntaServices, STipoPreguntaServices>();
builder.Services.AddTransient<IPreguntasServices, SPreguntaServices>();
builder.Services.AddTransient<IOpcionRespuestaServices, SOpcionRespuestaServices>();
builder.Services.AddTransient<IRespuestaDetalleServices, SRespuestaDetalleServices>();
builder.Services.AddTransient<IRespuestaEncuestaServices, SRespuestaEncuestaServices>();
builder.Services.AddTransient<IRespuestaMultipleServices, SRespuestaMultipleServices>();
builder.Services.AddTransient<IRespuestaEncuestaService, SRespuestaEncuestaService>();
builder.Services.AddTransient<IOpcionRespuestaCondicionService, SOpcionRespuestaCondicionService>();
builder.Services.AddTransient<IAnalisisEncuestaService, SAnalisisEncuestaService>();
builder.Services.AddTransient<IAsistenciaServiceSQL, AsistenciaServiceSinDTO>();

builder.Services.AddRadzenComponents();

builder.Services.AddMudServices();


builder.Services.AddDbContextFactory<EncuestaFeriaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlServerOptions => sqlServerOptions.EnableRetryOnFailure());
    options.EnableSensitiveDataLogging(true);
    options.UseLazyLoadingProxies(false);
});

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddDbContextFactory<BioTimeContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("BioTimeConnection"));
    options.EnableSensitiveDataLogging(true);
});


builder.Services.AddDbContextFactory<BioTimeSQLContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("BioTimeSQLConnection"),
        sqlServerOptions =>
        {
            // Retry en caso de fallas transitorias
            sqlServerOptions.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null);

            // Timeout de comandos (en segundos)
            sqlServerOptions.CommandTimeout(60);

            // Usar datetime2 para mejor precisión
            sqlServerOptions.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
        });

    // Logging sensible (útil para desarrollo, desactivar en producción)
    options.EnableSensitiveDataLogging(builder.Environment.IsDevelopment());

    // Lazy loading desactivado (buena práctica)
    options.UseLazyLoadingProxies(false);

    // Configurar advertencias
    options.ConfigureWarnings(warnings =>
    {
        warnings.Ignore(RelationalEventId.AmbientTransactionWarning);
        // Opcional: ignorar advertencias de consultas divididas
        // warnings.Ignore(RelationalEventId.MultipleCollectionIncludeWarning);
    });

    // Modo de seguimiento (solo en desarrollo para debugging)
    if (builder.Environment.IsDevelopment())
    {
        options.EnableDetailedErrors(true);
    }
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
