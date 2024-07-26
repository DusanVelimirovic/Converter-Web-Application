using Converter_Web_Application;
using Converter_Web_Application.Service;
using Converter_Web_Application.Service.Implementations;
using Converter_Web_Application.Service.Registrations.Cooking;
using Converter_Web_Application.Service.Registrations.Fuel;
using Converter_Web_Application.Service.Registrations.Travel;
using Converter_Web_Application.Service.Registrations.Unit;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register configuration API and Currency configuration services
builder.Services.AddScoped<IConfigurationService, ConfigurationService>();
builder.Services.AddScoped<ICurrencyConversionService, CurrencyConversionService>();

// Register translation service
builder.Services.AddScoped<TranslationService>();


// Register ConversionManagerService as a singleton
builder.Services.AddSingleton<ConversionManagerService>(sp =>
{
    var service = new ConversionManagerService();
    // Register Lenght conversions
    LengthConversions_registrations.Register(service);

    // Register Weight conversions
    WeightConversions_registrations.Register(service);

    // Register Volume conversions
    VolumeConversions_registrations.Register(service);

    // Register Temperature conversions
    TemperatureConversions_registrations.Register(service);

    // Register Area conversions
    AreaConversions_registrations.Register(service);

    // Register Time conversions
    TimeConversions_registrations.Register(service);

    // Register Digital storage conversions
    DigitalConversions_registrations.Register(service);

    // Register Speed conversions
    SugarConversions_registrations.Register(service);

    // Register a Cooking conversions

    // Sugar Conversions
    SugarConversions_registrations.Register(service);

    // Flour Conversions
    FlourConversions_registrations.Register(service);

    // Butter Conversions
    ButterConversions_registrations.Register(service);

    // Milk Conversions
    MilkConversions_registrations.Register(service);

    // Rice Conversions
    RiceConversions_registrations.Register(service);

    // Travel conversions
    TravelConversionsRegistration.Register(service);

    // Fuel conversions
    FuelConversionsRegistration.Register(service);
 

    return service;
});



var host = builder.Build();

//Initialize TranslationService
var translationService = host.Services.GetRequiredService<TranslationService>();
await translationService.InitializeAsync();

await host.RunAsync();

await builder.Build().RunAsync();
