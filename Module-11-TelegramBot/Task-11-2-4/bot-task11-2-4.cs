﻿using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Task_11_2_4
{
    internal class bot_task11_2_4: BackgroundService
    {
            private ITelegramBotClient _telegramClient;

            public bot_task11_2_4 (ITelegramBotClient telegramClient)
            {
                _telegramClient = telegramClient;
            }

            protected override async Task ExecuteAsync(CancellationToken stoppingToken)
            {
                _telegramClient.StartReceiving(HandleUpdate, HandleError, new ReceiverOptions() { AllowedUpdates = { } },cancellationToken: stoppingToken); 
            // Здесь выбираем, какие обновления хотим получать. В данном случае разрешены все

                Console.WriteLine("Бот запущен");
            }

       

        async Task HandleUpdate(ITelegramBotClient botClient, Update update, CancellationToken ct)
        {


            // Обрабатываем входящие сообщения из Telegram Bot API: https://core.telegram.org/bots/api#message
            if (update.Type == UpdateType.Message)
            {
                switch (update.Message!.Type)
                {
                    case MessageType.Text:  await _telegramClient.SendMessage(update.Message.From.Id, $"В вашем сообщении : {update.Message.Text.Length} символов", cancellationToken: ct);
                    return;

                    // unsupported message   
                    default: await _telegramClient.SendMessage(update.Message.From.Id, $"Данный тип сообщений не поддерживается. Пожалуйста отправьте текст.", cancellationToken: ct);
                    return;
                        
                }
            }
        }
         




        Task HandleError(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
            {
                // Задаем сообщение об ошибке в зависимости от того, какая именно ошибка произошла
                var errorMessage = exception switch
                {
                    ApiRequestException apiRequestException
                        => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                    _ => exception.ToString()
                };

                // Выводим в консоль информацию об ошибке
                Console.WriteLine(errorMessage);

                // Задержка перед повторным подключением
                Console.WriteLine("Ожидаем 10 секунд перед повторным подключением.");
                Thread.Sleep(10000);

                return Task.CompletedTask;
            }
        } 

        
}

