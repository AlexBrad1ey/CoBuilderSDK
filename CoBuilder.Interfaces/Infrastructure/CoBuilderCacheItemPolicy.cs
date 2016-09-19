using CoBuilder.Service.Interfaces;
using System;
using System.Runtime.Caching;

namespace CoBuilder.Service.Infrastructure
{
    public class CoBuilderCacheItemPolicy : CacheItemPolicy, ICachePolicy
    {
        public CoBuilderCacheItemPolicy()
            : this(
                DateTimeOffset.Now.AddMinutes(Constants.Caching.AbsoluteEvictionMinutes),
                TimeSpan.Zero)
        {
        }

        public CoBuilderCacheItemPolicy(DateTimeOffset absoluteExp, TimeSpan slidingExp)
        {
            AbsoluteExpiration = absoluteExp;
            SlidingExpiration = slidingExp;
            Priority = CacheItemPriority.Default;
        }
    }
}