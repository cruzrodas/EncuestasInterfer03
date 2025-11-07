using   EncuestasInterfer.Services.GeneroServices;
using EncuestasInterfer.Components;
using EncuestasInterfer.Models;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using EncuestasInterfer.Services.TiposCompraServices;
using EncuestasInterfer.Services.MotivoVisitaService;
using EncuestasInterfer.Services.TipoPublicidadServices;
using EncuestasInterfer.Services.TipoPublicidadService;
using EncuestasInterfer.Services.NacionalidadServices;
using EncuestasInterfer.Services.DepartamentoService;
using EncuestasInterfer.Services.DepartamentoServices;
using EncuestasInterfer.Services.MunicipioServices;
using EncuestasInterfer.Services.TipoIdentificacionService;
using EncuestasInterfer.Services.TipoIdentificacionServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddTransient<IGeneroServices, SGeneroServices>();
builder.Services.AddTransient<ITiposCompraServices, STiposCompraServices>();
builder.Services.AddTransient<IMotivoVisitaServices, SMotivoVisitaService>();
builder.Services.AddTransient<ITipoPublicidadServices, STipoPublicidadService>();
builder.Services.AddTransient<INacionalidadService, SNacionalidadServices>();
builder.Services.AddTransient<IDepartamenteServices, SDepartamentoServices>();
builder.Services.AddTransient<IMunicipioServices, SMunicipioServices>();
builder.Services.AddTransient<ITipoIdentificacionServices, STipoIdentificacionServices>();


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
