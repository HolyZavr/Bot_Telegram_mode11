using System;
using Telegram.Bot;
using Telegram.Bot.Args;


namespace Bot_Telegram_mode11
{
    class Program
    {
        static ITelegramBotClient botClient;

        static void Main(string[] args)
        {
            var bot = new BotWorker();

            bot.Inizalize();
            bot.Start();

            Console.WriteLine("Write 'stop' for end");

            string command;
            do
            {
                command = Console.ReadLine();
            } while (command != "stop");

            bot.Stop();

        }

        
    }

    class BotCredentials
    {
        public static readonly string BotToken = "2019657146:AAHrIAUw3xGR44gFQ_OA0WHgysSsKo0IPEk";
    }
}
