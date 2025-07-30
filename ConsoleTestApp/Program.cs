using ModAssemblerLib;
using ModAssemblerLib.DataClasses;
using ModAssemblerLib.Enums;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleTestApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string testPath = "C:\\Users\\gebruiker\\source\\repos\\ModAssembler\\ConsoleTestApp\\testfolder";
            string factorioDataDirectory = "C:\\UnityProjects\\FactorioModAssembler\\factorio-data";
            string fileName = "Test";
            string fileExtension = ".lua";

            Console.WriteLine("TestInfoFile");
            Console.WriteLine("==================================================");
            Console.WriteLine(TestData.TestInfoFile.ToString());
            Console.WriteLine("==================================================");

            Mod TestMod = new Mod()
            {
                Name = "TestModOmTeTesten",
            };

            ModBuilder builder = new ModBuilder(testPath, TestMod.Name);
            builder.BuildModDirectory();
            //builder.BuildItems();
            //builder.BuildTechnology();


            Console.WriteLine($"Writing {fileName + fileExtension} to {testPath} ");
            Console.WriteLine(TestData.TestItem.ToString());
            Console.WriteLine("==================================================");

            Console.WriteLine("Folders");
            Console.WriteLine("==================================================");
            Console.WriteLine(FolderDefination.Folders.GetValueOrDefault(FolderDefination.Folder.Locale));
            Console.WriteLine(FolderDefination.Folders.GetValueOrDefault(FolderDefination.Folder.Prototypes));
            Console.WriteLine(FolderDefination.Folders.GetValueOrDefault(FolderDefination.Folder.PrototypesFluids));
            Console.WriteLine(FolderDefination.Folders.GetValueOrDefault(FolderDefination.Folder.GraphicsIcons));
            Console.WriteLine("==================================================");

            Console.WriteLine("TestImport/Export");
            Console.WriteLine("==================================================");
            Data.Fluids.Add(TestData.TestFluid.Name, TestData.TestFluid);

            Fluid f2 = Data.GetFluidByName(TestData.TestFluid.Name);

            Console.WriteLine(TestData.TestFluid);
            Console.WriteLine(f2);

            Console.WriteLine("===================================================");
            Console.WriteLine(Data.Add(TestData.TestItem));
            Console.WriteLine(Data.Add(TestData.TestItem));
            Console.WriteLine(Data.Add(TestData.TestFluid));
            Console.WriteLine(Data.Add(TestData.TestFluid));
            Console.WriteLine("===================================================");


            Data.Add(new ItemGroup("itemgroup1", "a", TestData.TestIcon));
            Data.Add(new ItemGroup("itemgroup2", "b", TestData.TestIcon));
            Data.Add(new ItemGroup("itemgroup3", "c", TestData.TestIcon));
            Data.Add(new ItemGroup("itemgroup4", "d", TestData.TestIcon));
            Data.Add(new ItemGroup("itemgroup5", "e", TestData.TestIcon));

            Data.Add(new ItemSubGroup("subgroup1", "aa", Data.GetItemGroupByName("itemgroup1")));
            Data.Add(new ItemSubGroup("subgroup2", "aa", Data.GetItemGroupByName("itemgroup1")));
            Data.Add(new ItemSubGroup("subgroup3", "aa", Data.GetItemGroupByName("itemgroup2")));
            Data.Add(new ItemSubGroup("subgroup4", "aa", Data.GetItemGroupByName("itemgroup3")));
            Data.Add(new ItemSubGroup("subgroup5", "aa", Data.GetItemGroupByName("itemgroup1")));

            Data.Add(new Fluid()
            {
                Type = PrototypeDefinition.Fluid,
                DefaultTemperature = 25,
                BaseColor = new ColorSpecification(1,0,0,1),
                FlowColor = new ColorSpecification(1,0,0,1),
                Icon = TestData.TestIcon,
                MaxTemperature = 5000,
                Name = "lava",
                Order = "l",
            });

            
            Console.ReadLine();
        }  
    }
}
