using Terraria;
using Terraria.ModLoader;

namespace ExxoAvalonOrigins.Buffs.AdvancedBuffs;

public class AdvManaRegeneration : ModBuff
{
    public override void Update(Player player, ref int buffIndex)
    {
        player.manaRegenBuff = true;
    }
}
