using ExxoAvalonOrigins.Common;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExxoAvalonOrigins.Items.Material.Shards;

class ArcaneShard : ModItem
{
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 25;
    }

    public override void SetDefaults()
    {
        Rectangle dims = this.GetDims();
        Item.rare = ItemRarityID.LightPurple;
        Item.width = dims.Width;
        Item.maxStack = 9999;
        Item.value = Item.sellPrice(0, 0, 6, 0);
        Item.height = dims.Height;
    }
}
