/*************************************************************************
 *  Copyright © 2022 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Cache.cs
 *  Description  :  Cache for data.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0
 *  Date         :  7/20/2022
 *  Description  :  Initial development version.
 *************************************************************************/

using System;

namespace MGS.Cachers
{
    /// <summary>
    /// Cache for data.
    /// </summary>
    public readonly struct Cache<T>
    {
        /// <summary>
        /// Content of cache.
        /// </summary>
        public T Content { get; }

        /// <summary>
        /// Stamp of cache.
        /// </summary>
        public DateTime Stamp { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="content">Content of cache.</param>
        public Cache(T content)
        {
            Content = content;
            Stamp = DateTime.Now;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="content">Content of cache.</param>
        /// <param name="stamp">Stamp of cache.</param>
        public Cache(T content, DateTime stamp)
        {
            Content = content;
            Stamp = stamp;
        }
    }
}