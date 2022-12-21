using ModAssemblerLib;
using ModAssemblerLib.DataClasses;

namespace ConsoleTestApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            IconSpecificaction icon = new IconSpecificaction(32, "__TESTMOD__/Something/anotherthing");
            ItemGroup group = new ItemGroup("TestItemGroup", "a", icon);
            ItemSubGroup subGroup = new ItemSubGroup("TestItemSubGroup", "a", group);
            Item item = new Item("TestItem", icon, "a", 50, subGroup);

            string testPath = "C:\\Users\\timde\\source\\repos\\ModAssembler\\ConsoleTestApp\\testfolder";
            string fileName = "Test";
            string fileExtension = ".lua";

            InfoFile infoFile = new InfoFile()
            {
                Name = "Testfile",
                Version = "1.1.0",
                FactorioVersion = "1.0",
                Author = "Microsoft Corp.",
                Contact = "TestContact",
                Description = "This is a testdescription",
                Homepage = "www.test.com",
                Title = "Creative Title...",
                Dependencies = new List<InfoFileDependency>()
                {
                    new InfoFileDependency("TestMod1", "1.0.0"),
                    new InfoFileDependency("TestMod2", "0.0.1"),
                    new InfoFileDependency("TestMod3", "1.0.1")
                }
            };

            Console.WriteLine(infoFile.ToString());

            ModBuilder builder = new ModBuilder(testPath, "Arcanio");
            builder.BuildEmptyModFolder();
            //builder.BuildItems();
            //builder.BuildTechnology();

            Console.WriteLine($"Writing {fileName + fileExtension} to {testPath} ");
            Console.WriteLine(item.ToString());

            Console.WriteLine(FolderDefination.Folders.GetValueOrDefault(FolderDefination.Folder.Locale));
            Console.WriteLine(FolderDefination.Folders.GetValueOrDefault(FolderDefination.Folder.Prototypes));
            Console.WriteLine(FolderDefination.Folders.GetValueOrDefault(FolderDefination.Folder.PrototypesFluids));
            Console.WriteLine(FolderDefination.Folders.GetValueOrDefault(FolderDefination.Folder.GraphicsIcons));

            Console.ReadLine();
        }
    }
}