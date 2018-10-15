using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_MusicSheets_Service.Abstract
{
    public interface IFileTypeFactory

    {
        FileType Get(string fileName);
    }
}
