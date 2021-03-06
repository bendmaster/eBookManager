﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookManager.Helper
{
    class DocumentEngine
    {
        public (DateTime dateCreated, DateTime dateLastAccessed, string fileName, string fileExtension, long fileLength, bool error) GetFileProperties(string filePath)
        {
            var returnTuple = (created: DateTime.MinValue, dateLastAccessed: DateTime.MinValue, name: "", ext: "", fileSize: 0L, error: false);

            try
            {
                FileInfo fi = new FileInfo(filePath);
                fi.Refresh();
                returnTuple = (fi.CreationTime, fi.LastAccessTime, fi.Name, fi.Extension, fi.Length, false);
            }
            catch
            {
                returnTuple.error = true;
            }
            return returnTuple;
        }
    }
}
