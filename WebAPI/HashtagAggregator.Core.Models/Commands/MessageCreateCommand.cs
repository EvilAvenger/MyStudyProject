﻿using System;

using HashtagAggregator.Core.Models.Interface.Cqrs.Command;
using HashtagAggregator.Shared.Contracts.Enums;

namespace HashtagAggregator.Core.Models.Commands
{
    public class MessageCreateCommand : ICommand
    {
        public long Id { get; set; }

        public string MessageText { get; set; }

        public string HashTag { get; set; }

        public SocialMediaType MediaType { get; set; }

        public DateTime? PostDate { get; set; }

        public UserCreateCommand User { get; set; }

        public string NetworkId { get; set; }
    }
}