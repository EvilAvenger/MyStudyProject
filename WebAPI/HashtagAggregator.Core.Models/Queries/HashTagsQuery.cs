﻿using HashtagAggregator.Core.Models.Results.Query.HashTag;
using MediatR;

namespace HashtagAggregator.Core.Models.Queries
{
    public class HashTagsQuery : IRequest<HashTagsQueryResult>
    {
       public long ParentId { get; set; }
    }
}
