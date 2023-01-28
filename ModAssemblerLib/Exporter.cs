using ModAssemblerLib.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib
{
    public static class Exporter
    {
        public static void ExportItems(string modRoot)
        {
            foreach (Item i in Data.Items)
            {
                string finalPath = $"{modRoot}\\{FolderDefination.Folder.PrototypesItems}\\{i.Name.ToLower()}.lua";
                using (StreamWriter sw = File.CreateText(finalPath))
                {
                    sw.WriteLine("data:extend({");
                    sw.WriteLine(i.ToString());
                    sw.WriteLine("})");
                }
            }
        }

        public static void ExportItemGroups(string modRoot)
        {
            foreach (ItemGroup ig in Data.ItemGroups)
            {
                string finalPath = $"{modRoot}\\{FolderDefination.Folder.Prototypes}\\{ig.Name.ToLower()}.lua";
                using (StreamWriter sw = File.CreateText(finalPath))
                {
                    sw.WriteLine("data:extend({");
                    sw.WriteLine(ig.ToString());
                    sw.WriteLine("})");
                }
            }
        }

        public static void ExportItemSubGroups(string modRoot)
        {
            foreach (ItemSubGroup isg in Data.ItemSubGroups)
            {
                string finalPath = $"{modRoot}\\{FolderDefination.Folder.Prototypes}\\{isg.Name.ToLower()}.lua";
                using (StreamWriter sw = File.CreateText(finalPath))
                {
                    sw.WriteLine("data:extend({");
                    sw.WriteLine(isg.ToString());
                    sw.WriteLine("})");
                }
            }
        }

        public static void ExportTechnologies(string modRoot)
        {
            foreach (Technology t in Data.Technologies)
            {
                string finalPath = $"{modRoot}\\{FolderDefination.Folder.PrototypesTechnologies}\\{t.Name.ToLower()}.lua";
                using (StreamWriter sw = File.CreateText(finalPath))
                {
                    sw.WriteLine("data:extend({");
                    sw.WriteLine(t.ToString());
                    sw.WriteLine("})");
                }
            }
        }

        public static void ExportFluids(string modRoot)
        {
            foreach (Fluid f in Data.Fluids)
            {
                string finalPath = $"{modRoot}\\{FolderDefination.Folder.PrototypesFluids}\\{f.Name.ToLower()}.lua";
                using (StreamWriter sw = File.CreateText(finalPath))
                {
                    sw.WriteLine("data:extend({");
                    sw.WriteLine(f.ToString());
                    sw.WriteLine("})");
                }
            }
        }

        public static void ExportIcons()
        {

        }
    }
}
