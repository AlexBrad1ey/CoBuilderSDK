using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.Serialization;

namespace CoBuilder.Core.Authentication
{
    public class CredentialCache
    {
        private const int CacheVersion = 1;

        internal readonly IDictionary<CredentialCacheKey, ISession> CacheDictionary =
            new ConcurrentDictionary<CredentialCacheKey, ISession>();


        public virtual CredentialCacheNotification BeforeAccess { get; set; }
        public virtual CredentialCacheNotification BeforeWrite { get; set; }
        public virtual CredentialCacheNotification AfterAccess { get; set; }


        public virtual bool HasStateChanged { get; set; }


        public virtual void Clear()
        {
            var cacheNotificationArgs = new CredentialCacheNotificationArgs {CredentialCache = this};

            OnBeforeAccess(cacheNotificationArgs);
            OnBeforeWrite(cacheNotificationArgs);

            CacheDictionary.Clear();

            HasStateChanged = true;
            OnAfterAccess(cacheNotificationArgs);
        }

        internal virtual void AddToCache(ISession session)
        {
            var cacheNotificationArgs = new CredentialCacheNotificationArgs {CredentialCache = this};

            OnBeforeAccess(cacheNotificationArgs);
            OnBeforeWrite(cacheNotificationArgs);

            var cacheKey = GetKeyForSession(session);
            CacheDictionary[cacheKey] = session;

            HasStateChanged = true;
            OnAfterAccess(cacheNotificationArgs);
        }

        internal virtual void DeleteFromCache(ISession session)
        {
            if (session != null)
            {
                var cacheNotificationArgs = new CredentialCacheNotificationArgs {CredentialCache = this};
                OnBeforeAccess(cacheNotificationArgs);
                OnBeforeWrite(cacheNotificationArgs);

                var credentialCacheKey = GetKeyForSession(session);
                CacheDictionary.Remove(credentialCacheKey);

                HasStateChanged = true;

                OnAfterAccess(cacheNotificationArgs);
            }
        }

        //finalise key and session content
        internal virtual ISession GetResultFromCache(string userId, PluginApp appId)
        {
            var cacheNotificationArgs = new CredentialCacheNotificationArgs {CredentialCache = this};
            OnBeforeAccess(cacheNotificationArgs);

            //generate key from input parameters 
            var credentialCacheKey = new CredentialCacheKey
            {
                UserId = userId,
                AppId = appId
            };

            ISession cacheResult = null;
            CacheDictionary.TryGetValue(credentialCacheKey, out cacheResult);
            OnAfterAccess(cacheNotificationArgs);

            return cacheResult;
        }


        //finalise key and session content
        private CredentialCacheKey GetKeyForSession(ISession session)
        {
            return new CredentialCacheKey
            {
                UserId = "1",
                AppId = session.AppId
            };
        }

        private void OnAfterAccess(CredentialCacheNotificationArgs args)
        {
            AfterAccess?.Invoke(args);
        }

        private void OnBeforeWrite(CredentialCacheNotificationArgs args)
        {
            BeforeWrite?.Invoke(args);
        }

        private void OnBeforeAccess(CredentialCacheNotificationArgs args)
        {
            BeforeAccess?.Invoke(args);
        }
    }
}