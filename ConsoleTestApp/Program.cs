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

            //FileWriter.WriteFile(testPath + "\\" + fileName + fileExtension, TestInfoFile().ToString());

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