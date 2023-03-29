using InjectionDependence.Console.Service;
using Microsoft.Extensions.DependencyInjection;

//Create a collection of services
var serviceCollection = new ServiceCollection();

//config our class on collection services
serviceCollection.AddScoped<IGenerateGuid, GenerateGuid>();

//Building service
var serviceBuildProvider = serviceCollection.BuildServiceProvider();

//Request an instance of class GenerateGuid
var service = serviceBuildProvider.GetRequiredService<IGenerateGuid>();

Console.WriteLine("Guid Generated: " + service.Id);
Console.ReadLine();