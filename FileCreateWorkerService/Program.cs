// See https://aka.ms/new-console-template for more information
using DataAccess.Concrete.EntityFramework.Context;
using FileCreateWorkerService;
using FileCreateWorkerService.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

Console.WriteLine("Hello, World!");





static IHostBuilder CreateHostBuilder(string[] args) =>
       Host.CreateDefaultBuilder(args)
           .ConfigureServices((hostContext, services) =>
           {
               IConfiguration configuration = hostContext.Configuration;
               services.AddDbContext<ShoppingContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DBRentalContext")));
               services.AddSingleton(sp => new ConnectionFactory() { Uri = new Uri(configuration.GetConnectionString("RabbitMQ")), DispatchConsumersAsync = true });
               services.AddSingleton<RabbitMQClientService>();
               services.AddHostedService<Worker>();
           });