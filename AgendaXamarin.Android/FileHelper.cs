using System;
using System.IO;
using Xamarin.Forms;
using AgendaXamarin.Droid;

[assembly: Dependency(typeof(FileHelper))]
namespace AgendaXamarin.Droid
{
    public class FileHelper : IFileHelper
    {
        public FileHelper()
        {
        }
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}
