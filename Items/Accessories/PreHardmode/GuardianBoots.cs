using ExxoAvalonOrigins.Common;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExxoAvalonOrigins.Items.Accessories.PreHardmode;

class GuardianBoots : ModItem
{
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 1;
    }

    public override void SetDefaults()
    {
        Rectangle dims = this.GetDims();
        Item.defense = 2;
        Item.rare = ItemRarityID.Pink;
        Item.width = dims.Width;
        Item.accessory = true;
        Item.value = Item.sellPrice(0, 1, 44, 0);
        Item.height = dims.Height;
    }
    public override void AddRecipes()
    {
        CreateRecipe(1).AddIngredient(ItemID.ObsidianHorseshoe).AddIngredient(ItemID.CobaltShield).AddIngredient(ItemID.Spike, 50).AddTile(TileID.TinkerersWorkbench).Register();
        CreateRecipe(1).AddIngredient(ItemID.ObsidianShield).AddIngredient(ItemID.LuckyHorseshoe).AddIngredient(ItemID.Spike, 50).AddTile(TileID.TinkerersWorkbench).Register();
    }
    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.GetModPlayer<AvalonPlayer>().TrapImmune = true;
        player.noKnockback = true;
        player.noFallDmg = true;
        player.fireWalk = true;
    }
}
