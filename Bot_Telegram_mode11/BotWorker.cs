using System;
using Telegram.Bot;
using Telegram.Bot.Args;


namespace Bot_Telegram_mode11
{
    class BotWorker
    {
        private ITelegramBotClient botClient;
        private BotMessageLogic logic;

        public void Inizalize()
        {
            botClient = new TelegramBotClient(BotCredentials.BotToken);
            logic = new BotMessageLogic();
        }

        public void Start()
        {
            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
        }

        public void Stop()
        {
            botClient.StopReceiving();
        }

        private async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Text != null)
            {

                await botClient.SendTextMessageAsync(
                    chatId: e.Message.Chat,
                    text: "You wrote: \n" + e.Message.Text
                    );
            }
        }
    }
}
