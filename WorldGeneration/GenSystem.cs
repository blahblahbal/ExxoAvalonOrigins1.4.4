using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace ExxoAvalonOrigins.WorldGeneration
{
    public class GenSystem : ModSystem
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
        {
            // Because world generation is like layering several images ontop of each other, we need to do some steps between the original world generation steps.

            // The first step is an Ore. Most vanilla ores are generated in a step called "Shinies", so for maximum compatibility, we will also do this.
            // First, we find out which step "Shinies" is.

            GenPass currentPass;

            int index = tasks.FindIndex(genpass => genpass.Name.Equals("Reset"));

            if (index != -1)
            {
                tasks.Insert(index + 1, new Passes.AvalonReset("Avalon Reset", 1000f));
            }

            index = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));

            if (index != -1)
            {
                // Next, we insert our pass directly after the original "Shinies" pass.
                // ExampleOrePass is a class seen bellow
                tasks.Insert(index + 1, new Passes.OreGenPreHardmode("Adding Avalon Ores", 237.4298f));
            }

            index = tasks.FindIndex(genPass => genPass.Name == "Vines");
            if (index != -1)
            {
                currentPass = new Hooks.DungeonRemoveCrackedBricks();
                tasks.Insert(index + 1, currentPass);
                totalWeight += currentPass.Weight;
            }
        }
    }
}
