﻿using System;
using System.Threading.Tasks;

using MyStudyProject.Core.Contracts.Interface.ServiceFacades;
using MyStudyProject.Core.Contracts.Abstract;
using MyStudyProject.Core.Contracts.Interface.Cqrs.Query;
using MyStudyProject.Core.Models.Queries;
using MyStudyProject.Core.Models.Results.Query;

namespace MyStudyProject.Domain.Cqrs.Vk.Handlers
{
    public class VkMessagesGetQueryHandler : QueryHandler<MessageGetQuery, MessagesQueryResult>, IQueryHandler<MessageGetQuery, MessagesQueryResult>
    {
        private readonly IVkMessageFacade<MessagesQueryResult> facade;

        public VkMessagesGetQueryHandler(IVkMessageFacade<MessagesQueryResult> facade)
        {
            this.facade = facade;
        }

        public override Task<MessagesQueryResult> GetAsync(MessageGetQuery query)
        {
            return facade.GetAllAsync(query.HashTag);
        }
    }
}