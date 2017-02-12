﻿using System;

using MyStudyProject.Core.Models.Interface.Cqrs.Query;
using MyStudyProject.Shared.Contracts.Enums;

namespace MyStudyProject.Core.Models.Results.Query
{
    public class MessageQueryResult : IQueryResult
    {
        public MessageQueryResult(long id,
            string text,
            string hashtag,
            SocialMediaType mediaType,
            DateTime? postDate,
            string networkId,
            UserQueryResult user)
        {
            Id = id;
            Text = text;
            HashTag = hashtag;
            MediaType = mediaType;
            PostDate = postDate;
            NetworkId = networkId;
            User = user;
        }

        public MessageQueryResult()
        {
        }

        public long Id { get; set; }

        public string Text { get; set; }

        public string HashTag { get; set; }

        public SocialMediaType MediaType { get; set; }

        public DateTime? PostDate { get; set; }

        public string NetworkId { get; set; }

        public UserQueryResult User { get; set; }

        public override bool Equals(object obj)
        {
            var query = obj as MessageQueryResult;
            if (obj == null || query == null || GetType() != query.GetType())
            {
                return false;
            }
            return Id == query.Id
                   && Text.Equals(query.Text)
                   && HashTag.Equals(query.HashTag)
                   && MediaType == query.MediaType
                   && PostDate.Equals(query.PostDate)
                   && NetworkId.Equals(query.NetworkId);
        }

        public override int GetHashCode()
        {
            int hashCode = 17;
            hashCode = (hashCode * 23) + Id.GetHashCode();
            hashCode = (hashCode * 23) + Text.GetHashCode();
            hashCode = (hashCode * 23) + HashTag.GetHashCode();
            hashCode = (hashCode * 23) + MediaType.GetHashCode();
            hashCode = (hashCode * 23) + PostDate.GetHashCode();
            hashCode = (hashCode * 23) + NetworkId.GetHashCode();
            return hashCode;
        }
    }
}
