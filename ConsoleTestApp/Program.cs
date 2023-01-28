using ModAssemblerLib;
using ModAssemblerLib.DataClasses;
using System.Collections.Generic;
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

            Fluid testFluid = new Fluid()
            {
                Name = "TestFluid",
                DefaultTemperature = 15,
                BaseColor = new ColorSpecification(1f, 0f, 0f, 1f),
                FlowColor = new ColorSpecification(1f, 0.2f, 0.2f, 1f),
                MaxTemperature = 100,
                Order = "a",
                Type = PrototypeDefinition.Fluid,
                Icon = icon,
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

            Console.WriteLine(testFluid);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            string testString = 
                $$$"""
                        data:extend({{
                        type = "item",
                        name = "item-crusher",
                        icon = "__arcanio__/graphics/test.png",
                        icon_size = 32,
                        subgroup = "arcanio-processing",
                        order = "a",
                        place_result = "entity-crusher",
                        stack_size = 50,
                    }})
                """;

            //string testSub = testString.Substring(testString.IndexOf("subgroup") + 12);
            //Console.WriteLine(testSub);

            string a = Importer.ExtractValue(testString, "order");
            string iconstring = Importer.ExtractValue(testString, "icon");
            string shouldbenull = Importer.ExtractValue(testString, "kaas");

            Data.Fluids.Add(testFluid.Name, testFluid);

            Fluid f2 = Data.Fluids.FirstOrDefault(x => x.Key == testFluid.Name).Value;

            Console.WriteLine(testFluid);
            Console.WriteLine(f2);

            Console.ReadLine();
        }
    }
}