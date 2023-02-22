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
            SaveLocation = $"{ModFolderRootPath}\\{ModName}";
        }

        private void BuildEmptyModFolder()
        {
            EnsureDirectoryExists(SaveLocation + FolderDefination.Folders[FolderDefination.Folder.Graphics]);
            EnsureDirectoryExists(SaveLocation + FolderDefination.Folders[FolderDefination.Folder.Locale]);
            EnsureDirectoryExists(SaveLocation + FolderDefination.Folders[FolderDefination.Folder.Prototypes]);
            EnsureDirectoryExists(SaveLocation + FolderDefination.Folders[FolderDefination.Folder.PrototypesItems]);
            EnsureDirectoryExists(SaveLocation + FolderDefination.Folders[FolderDefination.Folder.Migrations]);
            EnsureDirectoryExists(SaveLocation + FolderDefination.Folders[FolderDefination.Folder.PrototypesEntities]);
            EnsureDirectoryExists(SaveLocation + FolderDefination.Folders[FolderDefination.Folder.PrototypesTechnologies]);
            EnsureDirectoryExists(SaveLocation + FolderDefination.Folders[FolderDefination.Folder.PrototypesFluids]);
            EnsureDirectoryExists(SaveLocation + FolderDefination.Folders[FolderDefination.Folder.PrototypesRecipes]);
        }

        private void EnsureDirectoryExists(string path)
        {
            if(!Directory.Exists(path)){
                Directory.CreateDirectory(path);
            }
        }

        public void BuildModDirectory()
        {
            BuildEmptyModFolder();
            Exporter.exportItemGroups(SaveLocation);
            Exporter.exportItemSubGroups(SaveLocation);
            Exporter.exportFluids(SaveLocation + FolderDefination.Folders[FolderDefination.Folder.PrototypesFluids]);
        }
    }
}
