using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EquilibriumMod.Items.Weapons
{
    public class BloodyFalchion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bloody Falchion");
            Tooltip.SetDefault("Left click to throw"
                + "\nRight click to swing");
        }

        public override void SetDefaults()
        {
            item.damage = 50;
            item.melee = true;
            item.width = 50;
            item.height = 54;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 8;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                {
                    return false;
                }
            }
            if (player.altFunctionUse == 2)
            {
                item.melee = true;
                item.noMelee = false;
                item.noUseGraphic = false;
                item.shoot = 0;
            }
            else
            {
                item.melee = true;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.shootSpeed = 20;
                item.shoot = mod.ProjectileType("BloodyFalchionProjectile");
            }
            return true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X * speedX, position.Y * speedY, 4f, 4f, mod.ProjectileType("BloodyFalchionProjectile"), item.damage, item.knockBack, 255, 0, 0);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BloodyMachete);
            recipe.AddIngredient(ItemID.DarkShard, 2);
            recipe.AddIngredient(ItemID.SoulofNight, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
