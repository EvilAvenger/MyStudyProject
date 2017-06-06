﻿using System.Collections.Generic;
using HashtagAggregator.Core.Contracts.Interface.Cqrs.Command;

namespace HashtagAggregator.Core.Models.Commands
{
    public class MessagesCreateCommand : ICommand
    {
        public MessagesCreateCommand()
        {
            Messages = new List<MessageCreateCommand>();
        }

        public List<MessageCreateCommand> Messages { get; set; }
    }
}
