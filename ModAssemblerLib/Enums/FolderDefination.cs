using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.Enums
{
    public static class FolderDefination
    {
        public enum Folder
        {
            Graphics, GraphicsIcons, GraphicsEnities, GraphicsTechnologies,
            Locale, Migrations, Prototypes, PrototypesItems, PrototypesEntities,
            PrototypesTechnologies, PrototypesRecipes, PrototypesFluids,
        }

        public static readonly Dictionary<Folder, string> Folders = new() {
            {Folder.Graphics,               "\\graphics"},
            {Folder.GraphicsIcons,          "\\graphics\\icons"},
            {Folder.GraphicsEnities,        "\\graphics\\entities"},
            {Folder.GraphicsTechnologies,   "\\graphics\\technology"},
            {Folder.Locale,                 "\\locale"},
            {Folder.Migrations,             "\\migrations"},
            {Folder.Prototypes,             "\\prototypes"},
            {Folder.PrototypesItems,        "\\prototypes\\items"},
            {Folder.PrototypesEntities,     "\\prototypes\\entities"},
            {Folder.PrototypesTechnologies, "\\prototypes\\technologies"},
            {Folder.PrototypesFluids,       "\\prototypes\\fluids"},
            {Folder.PrototypesRecipes,      "\\prototypes\\recipes"},
        };
    }
}
