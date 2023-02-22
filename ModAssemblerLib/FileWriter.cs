using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ModAssemblerLib
{
    public static class FileWriter
    {
        public static void WriteFile(string path, string content)
        {
            File.WriteAllText(path, content);
            //EnsureFileExists(path);
            //StreamWriter s = new(path);
            //s.Write(content);
            //s.Close();
        }


        static bool EnsureFileExists(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                return true;
            }
            return false;
        }
    }
}
