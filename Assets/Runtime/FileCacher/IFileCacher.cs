/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  IFileCacher.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  07/30/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;

namespace MGS.Cacher
{
    public interface IFileCacher : ICacher<string>
    {
        string GetFilePath(string fileName);

        byte[] ReadAllBytes(string fileName, out Exception error);

        string ReadAllText(string fileName, out Exception error);

        Exception WriteAllBytes(string fileName, byte[] bytes);

        Exception WriteAllText(string fileName, string contents);
    }
}