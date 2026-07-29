/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  FileCacher.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  07/29/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using System.IO;
using MGS.IO;
using UnityEngine;

namespace MGS.Cacher
{
    public class FileCacher : IFileCacher
    {
        #region
        protected string directory;

        public FileCacher(string directory)
        {
            this.directory = directory;
            var error = DirectoryUtility.Require(directory);
            LogIfError(error);
        }

        protected void LogIfError(Exception error)
        {
            if (error != null)
            {
                Debug.LogException(error);
            }
        }
        #endregion

        #region
        public void Add(string fileName, string contents)
        {
            var error = WriteAllText(fileName, contents);
            LogIfError(error);
        }

        public string Find(string fileName)
        {
            var filePath = GetFilePath(fileName);
            if (File.Exists(filePath))
            {
                return filePath;
            }
            return null;
        }

        public void Delete(string fileName)
        {
            var path = GetFilePath(fileName);
            var error = FileUtility.Delete(path);
            LogIfError(error);
        }

        public void Clear()
        {
            var error = DirectoryUtility.Delete(directory);
            if (error == null)
            {
                error = DirectoryUtility.Require(directory);
            }
            LogIfError(error);
        }
        #endregion

        #region
        public string GetFilePath(string fileName)
        {
            return $"{directory}/{fileName}";
        }

        public byte[] ReadAllBytes(string fileName, out Exception error)
        {
            var path = GetFilePath(fileName);
            return FileUtility.ReadAllBytes(path, out error);
        }

        public string ReadAllText(string fileName, out Exception error)
        {
            var path = GetFilePath(fileName);
            return FileUtility.ReadAllText(path, out error);
        }

        public Exception WriteAllBytes(string fileName, byte[] bytes)
        {
            var path = GetFilePath(fileName);
            return FileUtility.WriteAllBytes(path, bytes);
        }

        public Exception WriteAllText(string fileName, string contents)
        {
            var path = GetFilePath(fileName);
            return FileUtility.WriteAllText(path, contents);
        }
        #endregion
    }
}