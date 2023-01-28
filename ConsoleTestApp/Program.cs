using ModAssemblerLib;
using ModAssemblerLib.DataClasses;
using System.Text.RegularExpressions;

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

            string testPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "Test";
            string fileExtension = ".lua";

            Data.ItemGroups.Add(new ItemGroup("TestGroup1", "a", icon));
            Data.ItemGroups.Add(new ItemGroup("TestGroup2", "b", icon));
            Data.ItemGroups.Add(new ItemGroup("TestGroup3", "c", icon));
            Data.ItemGroups.Add(new ItemGroup("TestGroup4", "d", icon));
            Data.ItemGroups.Add(new ItemGroup("TestGroup5", "e", icon));

            Data.Icons.Add(new IconSpecificaction(32, "TestPath1"));
            Data.Icons.Add(new IconSpecificaction(64, "TestPath2"));
            Data.Icons.Add(new IconSpecificaction(64, "TestPath3"));
            Data.Icons.Add(new IconSpecificaction(69, "TestPath4Nice"));
            Data.Icons.Add(new IconSpecificaction(32, "TestPath5"));

            ModBuilder builder = new ModBuilder(testPath, "Arcanio");
            builder.BuildModDirectory();

            Console.ReadLine();
        }
    }
}