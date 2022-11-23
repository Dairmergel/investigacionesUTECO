using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using InvestigacionesUTECO.Data;
using InvestigacionesUTECO.Data.Context;
using InvestigacionesUTECO.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSqlite<UTECODbContext>("Data Source=.//Data//Context//UTECO_DB.sqlite");
//Agregamos los servicios para la base de datos
builder.Services.AddScoped<IUTECODbContext,UTECODbContext>();
builder.Services.AddScoped<IUsuarioServices,UsuarioServices>();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<IFomularioSevices,FomularioSevices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<UTECODbContext>();
    if (db.Database.EnsureCreated())
    {
        
    }
}
app.Run();
