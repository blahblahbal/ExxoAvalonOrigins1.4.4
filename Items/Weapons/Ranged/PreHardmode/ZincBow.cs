using ExxoAvalonOrigins.Common;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExxoAvalonOrigins.Items.Weapons.Ranged.PreHardmode;

class ZincBow : ModItem
{
    public override void SetStaticDefaults()
    {
        Item.ResearchUnlockCount = 1;
    }
    public override void SetDefaults()
    {
        Rectangle dims = this.GetDims();
        Item.UseSound = SoundID.Item5;
        Item.damage = 12;
        Item.scale = 1f;
        Item.shootSpeed = 6.5f;
        Item.useAmmo = AmmoID.Arrow;
        Item.DamageType = DamageClass.Ranged;
        Item.noMelee = true;
        Item.width = dims.Width;
        Item.useTime = 25;
        Item.knockBack = 0f;
        Item.shoot = ProjectileID.WoodenArrowFriendly;
        Item.useStyle = ItemUseStyleID.Shoot;
        Item.value = 4500;
        Item.useAnimation = 25;
        Item.height = dims.Height;
    }
    public override void AddRecipes()
    {
        Terraria.Recipe.Create(Type)
            .AddIngredient(ModContent.ItemType<Material.Bars.ZincBar>(), 7)
            .AddTile(TileID.Anvils)
            .Register();
    }
}
