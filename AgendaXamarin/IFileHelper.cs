using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaXamarin
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}