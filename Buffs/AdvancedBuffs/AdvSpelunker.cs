using Terraria;
using Terraria.ModLoader;

namespace ExxoAvalonOrigins.Buffs.AdvancedBuffs;

public class AdvSpelunker : ModBuff
{
    public override void Update(Player player, ref int buffIndex)
    {
        player.findTreasure = true;
    }
}
