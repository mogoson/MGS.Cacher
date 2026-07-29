/*************************************************************************
 *  Copyright © 2022 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ICacher.cs
 *  Description  :  Interface of cacher.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0
 *  Date         :  7/20/2022
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.Cacher
{
    public interface ICacher<T>
    {
        void Add(string key, T value);

        T Find(string key);

        void Delete(string key);

        void Clear();
    }
}