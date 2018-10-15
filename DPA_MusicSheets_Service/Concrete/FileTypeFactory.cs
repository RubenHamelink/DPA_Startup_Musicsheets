using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPA_MusicSheets_Service.Abstract;

namespace DPA_MusicSheets_Service.Concrete
{
    public class FileTypeFactory : IFileTypeFactory
    {
        private Dictionary<string, FileType> dict;

        public FileTypeFactory()
        {
            dict = new Dictionary<string, FileType>();
            dict.Add(".mid", new MidiFile());
            dict.Add(".ly", new LilyFile());
        }

        public FileType Get(string fileName)
        {
            dict.TryGetValue(Path.GetExtension(fileName), out FileType file);

            return file;
        }
    }
}
