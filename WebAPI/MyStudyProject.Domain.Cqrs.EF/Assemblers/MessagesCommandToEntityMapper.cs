﻿using System.Collections.Generic;
using MyStudyProject.Core.Entities.EF;
using MyStudyProject.Core.Models.Commands;

namespace MyStudyProject.Domain.Cqrs.EF.Assemblers
{
    public class MessagesCommandToEntityMapper
    {
        public List<MessageEntity> MapBunch(IEnumerable<MessageCreateCommand> messages)
        {
            var results = new List<MessageEntity>();
            UserCommandToEntityMapper mapper = new UserCommandToEntityMapper();
            foreach (var message in messages)
            {
                MessageEntity entity = new MessageEntity
                {
                    MessageText = message.MessageText,
                    HashTag = message.HashTag,
                    MediaType = message.MediaType,
                    User = mapper.MapSingle(message.User),
                    PostDate = message.PostDate,
                    Id = message.Id,
                    NetworkId =  message.NetworkId
                };
                results.Add(entity);
            }
            return results;
        }
    }
}

