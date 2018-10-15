using DPA_MusicSheets_Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_MusicSheets_Service.Concrete
{
    public class LilyFile : FileType
    {
        public override string Title
        {
            get
            {
                return "Lily";
            }
        }
    }
}
