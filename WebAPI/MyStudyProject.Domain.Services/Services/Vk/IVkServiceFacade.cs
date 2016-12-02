﻿using MyStudyProject.Core.Contracts.Interface.ServiceFacades;
using MyStudyProject.Core.Cqrs.Results;

namespace MyStudyProject.Domain.Services.Services.Vk
{
    public interface IVkServiceFacade : IMessageServiceFacade<MessageQueryResult>
    {
    }
}
