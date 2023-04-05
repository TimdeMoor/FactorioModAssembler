using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAssemblerLib.DataClasses
{
    public static class FastReplaceableGroupDefination
    {
        public enum FastReplaceableGroup
        {
            ConstantCombinator, Container, Furnace, TransportBelt,
            ElectricPole, SteamEngine, Inserter, LongHandedInserter,
            Pipe, AssemblingMachine, Wall, Loader, RailSignal,
            LinkedBelts, MiningDrill, Pumpjack
        }

        public static readonly Dictionary<FastReplaceableGroup, string> FastReplaceableGroups = new()
        {
            {FastReplaceableGroup.ConstantCombinator, "constant-combinator"},
            {FastReplaceableGroup.Container, "container"},
            {FastReplaceableGroup.Furnace, "furnace"},
            {FastReplaceableGroup.TransportBelt, "transport-belt"},
            {FastReplaceableGroup.ElectricPole, "electric-pole"},
            {FastReplaceableGroup.SteamEngine, "steam-engine"},
            {FastReplaceableGroup.Inserter, "inserter"},
            {FastReplaceableGroup.LongHandedInserter, "long-handed-inserter"},
            {FastReplaceableGroup.Pipe, "pipe"},
            {FastReplaceableGroup.AssemblingMachine, "assembling-machine"},
            {FastReplaceableGroup.Wall, "wall"},
            {FastReplaceableGroup.Loader, "loader"},
            {FastReplaceableGroup.RailSignal, "rail-signal"},
            {FastReplaceableGroup.LinkedBelts, "linked-belts"},
            {FastReplaceableGroup.MiningDrill, "mining-drill"},
            {FastReplaceableGroup.Pumpjack, "pumpjack"},

        };
    }
}
