using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NW.AL.Common.Interfaces;
using NW.AL.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace NW.AL.iOS
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, filename);
        }

    }

}
