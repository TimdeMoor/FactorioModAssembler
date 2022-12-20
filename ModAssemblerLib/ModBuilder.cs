using ModAssemblerLib.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib
{
    public class ModBuilder
    {
        public string ModFolderRootPath { get; set; }
        public string ModName { get; set; }
        private string SaveLocation;

        public ModBuilder(string modFolderRootPath, string modName)
        {
            ModFolderRootPath = modFolderRootPath;
            ModName = modName;
            SaveLocation = $"{ModFolderRootPath}\\{ModName}\\";
        }

        public void BuildEmptyModFolder()
        {
        //    EnsureDirectoryExists(SaveLocation + FolderDefination.Graphics);
        //    EnsureDirectoryExists(SaveLocation + FolderDefination.Locale);
        //    EnsureDirectoryExists(SaveLocation + FolderDefination.Prototypes);
        //    EnsureDirectoryExists(SaveLocation + FolderDefination.ItemPrototypes);
        //    EnsureDirectoryExists(SaveLocation + FolderDefination.Migrations);
        //    EnsureDirectoryExists(SaveLocation + FolderDefination.EntityPrototypes);
        //    EnsureDirectoryExists(SaveLocation + FolderDefination.TechnologyPrototypes);
        //    EnsureDirectoryExists(SaveLocation + FolderDefination.FluidPrototypes);
        //    EnsureDirectoryExists(SaveLocation + FolderDefination.RecipePrototypes);
        }

        private void EnsureDirectoryExists(string path)
        {
            if(!Directory.Exists(path)){
                Directory.CreateDirectory(path);
            }
        }

        public void BuildFolder(string folderDefinationString)
        {

        }
    }
}
