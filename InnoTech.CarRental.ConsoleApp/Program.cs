using System;
using System.Linq;
using InnoTech.CarRental.Core.ApplicationService;
using InnoTech.CarRental.Core.ApplicationService.Impl;
using InnoTech.CarRental.Core.DomainService;
using InnoTech.CarRental.Infrastructure.Data;
using InnoTech.Core.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace InnoTech.CarRental.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FakeDB.InitData();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ICarRepository, CarRepository>();
            serviceCollection.AddScoped<ICarService, CarService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var carService = serviceProvider.GetRequiredService<ICarService>();
            new Printer(carService);

            Console.ReadLine();
            /*////then build provider 
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var printer = serviceProvider.GetRequiredService<IPrinter>();
            printer.StartUI();*/
        }
    }
}
