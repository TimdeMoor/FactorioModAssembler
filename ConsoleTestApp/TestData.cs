using ModAssemblerLib;
using ModAssemblerLib.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public static class TestData
    {
        public static Icon TestIcon = new()
        {
            IconSize = 32,
            LocalPath = $"__Arcanio__/graphics/icons",
        };

        public static ItemGroup TestItemGroup = new()
        {
            Icon = TestIcon,
            Name = "TestItemGroup",
            Order = "a",
        };

        public static InfoFile TestInfoFile = new InfoFile()
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
                    new InfoFileDependency("TestMod1", "1.0.0", InfoFileDependency.InfoFileDependencyType.Required),
                    new InfoFileDependency("TestMod2", "0.0.1", InfoFileDependency.InfoFileDependencyType.Optional),
                    new InfoFileDependency("TestMod3", "1.0.1", InfoFileDependency.InfoFileDependencyType.Incompatible)
                }
        };

        public static Fluid TestFluid = new Fluid()
        {
            Name = "TestFluid",
            DefaultTemperature = 15,
            BaseColor = new ColorSpecification(1f, 0f, 0f, 1f),
            FlowColor = new ColorSpecification(1f, 0.2f, 0.2f, 1f),
            MaxTemperature = 100,
            Order = "a",
            Type = PrototypeDefinition.Fluid,
            Icon = TestIcon,
        };

        public static ItemSubGroup TestItemSubGroup = new()
        {
            Group = TestItemGroup,
            Name = "TestItemSubGroup",
            Order = "a",
            Type = PrototypeDefinition.Item,
        };

        public static Item TestItem = new()
        {
            Name = "Item",
            Icon = TestIcon,
            Order = "a",
            StackSize = 50,
            ItemSubGroup = TestItemSubGroup,
        };
    }
}
