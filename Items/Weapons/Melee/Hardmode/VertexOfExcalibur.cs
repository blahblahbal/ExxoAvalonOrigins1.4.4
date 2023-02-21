﻿using ExxoAvalonOrigins.Projectiles.Melee;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExxoAvalonOrigins.Items.Weapons.Melee.Hardmode
{
    public class VertexOfExcalibur : ModItem
    {
        public override void SetStaticDefaults()
        {
            //"Deals more damage to enemies affected by a debuff\n'The unification of dark and light'"
            Item.ResearchUnlockCount = 1;
        }
        public override void SetDefaults()
        {
            Item.Size = new Vector2(30);
            Item.UseSound = SoundID.Item1;
            Item.damage = 90;
            Item.autoReuse = true;
            Item.noMelee = true;
            Item.rare = ItemRarityID.Yellow;
            Item.useTime = 18;
            Item.knockBack = 5f;
            Item.DamageType = DamageClass.Melee;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.value = Item.sellPrice(0, 9, 63, 0);
            Item.useAnimation = 18;
            Item.shoot = ModContent.ProjectileType<VertexSlash>();
            Item.shootSpeed = 16;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {

            float adjustedItemScale5 = player.GetAdjustedItemScale(player.HeldItem);
            Projectile.NewProjectile(source, player.MountedCenter, new Vector2(player.direction, 0f), type, 0, knockback, player.whoAmI, (float)player.direction * player.gravDir, player.itemAnimationMax, adjustedItemScale5 * 1f);
            Projectile.NewProjectile(source, player.MountedCenter, velocity, type, damage, knockback, player.whoAmI, (float)player.direction * player.gravDir * 0.08f, 30, adjustedItemScale5 * 1.2f);
            NetMessage.SendData(13, -1, -1, null, player.whoAmI);
            return false;
        }
        public override void AddRecipes()
        {
            Recipe.Create(Type)
                .AddIngredient(ItemID.NightsEdge)
                .AddIngredient(ItemID.Excalibur)
                .AddIngredient(ItemID.BrokenHeroSword)
                .AddIngredient(ItemID.DarkShard)
                .AddIngredient(ItemID.LightShard)
                .AddIngredient(ItemID.BeetleHusk, 4)
                .AddTile(TileID.AdamantiteForge).Register();
        }
    }
}
