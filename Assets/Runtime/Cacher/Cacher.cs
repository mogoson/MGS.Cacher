/*************************************************************************
 *  Copyright © 2022 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Cacher.cs
 *  Description  :  Cacher for cache data.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0
 *  Date         :  7/20/2022
 *  Description  :  Initial development version.
 *************************************************************************/

using System.Collections.Generic;

namespace MGS.Cacher
{
    public class Cacher<T> : ICacher<T>
    {
        protected Dictionary<string, T> caches = new();
        protected int capacity;

        public Cacher(int capacity = 100)
        {
            this.capacity = capacity;
        }

        public virtual void Add(string key, T value)
        {
            TrimExcess(capacity - 1);
            caches[key] = value;
        }

        public virtual T Find(string key)
        {
            if (caches.ContainsKey(key))
            {
                return caches[key];
            }
            return default;
        }

        public virtual void Delete(string key)
        {
            caches.Remove(key);
        }

        public virtual void Clear()
        {
            caches.Clear();
        }

        protected void TrimExcess(int count)
        {
            if (caches.Count > count)
            {
                var keys = caches.Keys.GetEnumerator();
                while (caches.Count > count)
                {
                    keys.MoveNext();
                    caches.Remove(keys.Current);
                }
            }
        }
    }
}