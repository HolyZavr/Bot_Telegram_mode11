using System;
using System.Collections.Generic;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace Bot_Telegram_mode11
{
    public class BotMessageLogic
    {
        private Messenger messanger;


        private Dictionary<long, Conversation> chatList;

        public BotMessageLogic(ITelegramBotClient botClient)
        {
            messanger = new Messenger();
        }

    }
}
