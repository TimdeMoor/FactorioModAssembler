using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib
{
    public static class ZipManager
    {
        public static void CreateZipArchive(string directoryPath, string destinationPath)
        {
            ZipFile.CreateFromDirectory(directoryPath, destinationPath, CompressionLevel.Fastest, true);
        }

        public static void ExtractZipArchive(string zipFilePath, string destinationPath)
        {
            ZipFile.ExtractToDirectory(zipFilePath, destinationPath, true);
        }
    }
}
