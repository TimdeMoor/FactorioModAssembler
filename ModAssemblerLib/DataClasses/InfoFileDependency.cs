namespace ModAssemblerLib.DataClasses
{
    public class InfoFileDependency
    {
        string ModName { get; set; }
        string ModVersion { get; set; }
        InfoFileDependencyType infoFileDependencyType { get; set; }

        public InfoFileDependency(string modName, string modVersion, InfoFileDependencyType InfoFileDependencyType)
        {
            ModName = modName;
            ModVersion = modVersion;
            infoFileDependencyType = InfoFileDependencyType;
        }

        public InfoFileDependency(string input)
        {
            string[] split = input.Split(" >= ");
            ModName = split[0];
            ModVersion = split[1];
            infoFileDependencyType = InfoFileDependencyType.Required;

            if (ModName.StartsWith("?"))
            {
                infoFileDependencyType = InfoFileDependencyType.Optional;
                ModName = ModName.TrimStart("?"[0]);
            }else if (ModName.StartsWith("!"))
            {
                infoFileDependencyType = InfoFileDependencyType.Incompatible;
                ModName = ModName.TrimStart("!"[0]);
            }
        }

        public enum InfoFileDependencyType
        {
            Required, Optional, Incompatible
        }

        public static readonly Dictionary<InfoFileDependencyType, string> InfoFileDependencyTypes = new()
        {
            {InfoFileDependencyType.Required, string.Empty},
            {InfoFileDependencyType.Optional, "?"},
            {InfoFileDependencyType.Incompatible, "!"},
        };

        public override string ToString()
        {
            string dependencyValue;
            _ = InfoFileDependencyTypes.TryGetValue(infoFileDependencyType, out dependencyValue);
            return $$""""{{dependencyValue}}{{ModName}} >= {{ModVersion}}"""";
        }
    }
}
