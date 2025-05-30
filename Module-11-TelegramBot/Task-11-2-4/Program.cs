﻿using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Telegram.Bot;
using VoiceTexterBot.Controllers;

namespace Task_11_2_4
{
    internal class Program
    {
        public static async Task Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            // Объект, отвечающий за постоянный жизненный цикл приложения
            var host = new HostBuilder()
           .ConfigureServices((hostContext, services) => ConfigureServices(services)) // Задаем конфигурацию
           .UseConsoleLifetime() // Позволяет поддерживать приложение активным в консоли
           .Build(); // Собираем

            Console.WriteLine("Сервис запущен");
            // Запускаем сервис
            await host.RunAsync();

            Console.WriteLine("Сервис остановлен");
        }

        static void ConfigureServices(IServiceCollection services)
        {
            // Регистрируем объект TelegramBotClient c токеном подключения
            services.AddSingleton<ITelegramBotClient>(provider => new TelegramBotClient("8106712489:AAG6Nfh5bLpYjjo7sb3GiiCsRBcXsecMoXs"));
            // Регистрируем постоянно активный сервис бота
            services.AddHostedService<bot_task11_2_4>();
            
        }
    }
}
