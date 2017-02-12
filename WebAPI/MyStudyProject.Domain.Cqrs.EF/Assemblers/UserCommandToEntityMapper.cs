﻿using MyStudyProject.Core.Entities.EF;
using MyStudyProject.Core.Models.Commands;

namespace MyStudyProject.Domain.Cqrs.EF.Assemblers
{
    public class UserCommandToEntityMapper
    {
        public UserEntity MapSingle(UserCreateCommand item)
        {
            UserEntity query = null;
            if (item != null)
            {
                query = new UserEntity();
                query.Id = item.Id;
                query.NetworkId = item.NetworkId;
                query.UserName = item.UserName;
                query.ProfileId = item.ProfileId;
                query.Url = item.Url;
            }
            return query;
        }
    }
}
