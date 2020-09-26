using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EquilibriumMod.Items.Weapons
{
    public class TrueLucentNight : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Lucent Night");
            Tooltip.SetDefault("'Kage Bunshin no Jutsu'");
        }

        public override void SetDefaults()
        {
            item.damage = 66;
            item.melee = true;
            item.width = 26;
            item.height = 32;
            item.useTime = 5;
            item.useAnimation = 5;
            item.noUseGraphic = true;
            item.useStyle = 2;
            item.knockBack = 6.25F;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.rare = 8;
            item.shootSpeed = 10;
            item.shoot = mod.ProjectileType("TrueLucentNightProjectile");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("LucentNight"));
            recipe.AddIngredient(mod.ItemType("BrokenHeroBoomerang"));
            recipe.AddIngredient(ItemID.CursedFlame, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
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
            return true;
        }
    }
}
