using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public static class FolderDefination
    {
        public enum Folder
        {
            Graphics,
            GraphicsIcons,
            GraphicsEnities,
            GraphicsTechnologies,
            Locale,
            Migrations,
            Prototypes,
            PrototypesItems,
            PrototypesEntities,
            PrototypesTechnologies,
            PrototypesRecipes,
            PrototypesFluids,
        }

        public static readonly Dictionary<Folder, string> Folders = new Dictionary<Folder, string>() {
            {Folder.Graphics, "graphics"},
            {Folder.GraphicsIcons, Folders.GetValueOrDefault(Folder.Graphics) + "\\" + "icons"},
            {Folder.GraphicsEnities, Folders.GetValueOrDefault(Folder.Graphics) + "\\" + "entities"},
            {Folder.GraphicsTechnologies, Folders.GetValueOrDefault (Folder.Graphics) + "\\" + "technology"},
            {Folder.Locale, "locale"},
            {Folder.Migrations, "migrations"},
            {Folder.Prototypes, "prototypes"},
            {Folder.PrototypesItems, Folders.GetValueOrDefault(Folder.Prototypes) + "\\" + "items"},
            {Folder.PrototypesEntities, Folders.GetValueOrDefault(Folder.Prototypes) + "\\" + "entities"},
            {Folder.PrototypesTechnologies, Folders.GetValueOrDefault(Folder.Prototypes) + "\\" + "technologies"},
            {Folder.PrototypesFluids, Folders.GetValueOrDefault(Folder.Prototypes) + "\\" + "fluids"},
            {Folder.PrototypesRecipes, Folders.GetValueOrDefault(Folder.Prototypes) + "\\" + "recipes"},
        };
    }
}
