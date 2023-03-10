using ExxoAvalonOrigins.Common;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExxoAvalonOrigins.Items.Accessories.PreHardmode;

internal class CloudGlove : ModItem
{
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 1;
    }

    public override void SetDefaults()
    {
        Rectangle dims = this.GetDims();
        Item.rare = ItemRarityID.LightRed;
        Item.width = dims.Width;
        Item.accessory = true;
        Item.value = Item.sellPrice(0, 1);
        Item.height = dims.Height;
        Item.GetGlobalItem<AvalonGlobalItemInstance>().WorksInVanity = true;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.GetModPlayer<AvalonPlayer>().CloudGlove = true;
    }

    public override void UpdateVanity(Player player)
    {
        player.GetModPlayer<AvalonPlayer>().CloudGlove = true;
    }

    public override void AddRecipes()
    {
        CreateRecipe().AddIngredient(ItemID.Silk, 15)
            .AddIngredient(ItemID.Cloud, 25)
            .AddIngredient(ItemID.SoulofFlight, 5)
            .AddRecipeGroup("ExxoAvalonOrigins:GoldBar", 5)
            .AddIngredient(ItemID.SunplateBlock, 10)
            .AddTile(TileID.TinkerersWorkbench)
            .Register();
    }
}
