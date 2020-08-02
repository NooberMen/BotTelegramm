using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace lubOfBrutalMen_bot.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "hello";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId    = message.Chat.Id;
            var messageId = message.MessageId;

           //Логика телеграмм бота

            await client.SendTextMessageAsync(chatId, "Hello", replyToMessageId: messageId);
        }
    }
}