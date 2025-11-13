using   EncuestasInterfer.Services.GeneroServices;
using EncuestasInterfer.Components;
using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using EncuestasInterfer.Services.NacionalidadServices;
using EncuestasInterfer.Services.DepartamentoService;
using EncuestasInterfer.Services.DepartamentoServices;
using EncuestasInterfer.Services.MunicipioServices;
using EncuestasInterfer.Services.TipoIdentificacionService;
using EncuestasInterfer.Services.TipoIdentificacionServices;
using EncuestasInterfer.Services.EncuestasServices;
using EncuestasInterfer.Services.EncuestaServices;
using EncuestasInterfer.Services.TipoPreguntaServices;
using EncuestasInterfer.Services.PreguntasServices;
using EncuestasInterfer.Services.OpcionRespuestaServices;
using EncuestasInterfer.Services.RespuestaDetalleServices;
using EncuestasInterfer.Services.RespuestaEncuestaServices;
using EncuestasInterfer.Services.RespuestaMultipleServices;
using EncuestasInterfer.Services.RespuestaEncuestaService;
using EncuestasInterfer.Services.OpcionRespuestaCondicionService;

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

builder.Services.AddMudServices();


builder.Services.AddDbContextFactory<EncuestaFeriaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlServerOptions => sqlServerOptions.EnableRetryOnFailure());
    options.EnableSensitiveDataLogging(true);
    options.UseLazyLoadingProxies(false);
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
