using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EquilibriumMod.Items.Weapons
{
    public class LucentNight : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("LucentNight"); //
        }

        public override void SetDefaults()
        {
            item.damage = 38;
            item.melee = true;
            item.width = 24;
            item.height = 32;
            item.useTime = 5;
            item.useAnimation = 5;
            item.noUseGraphic = true;
            item.useStyle = 2;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 1, 8, 0);
            item.rare = 3;
            item.shootSpeed = 7.5F;
            item.shoot = mod.ProjectileType("LucentNightProjectile");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("TheShade"));
            recipe.AddIngredient(mod.ItemType("Aquaken"));
            recipe.AddIngredient(ItemID.Flamarang, 1);
            recipe.AddIngredient(ItemID.ThornChakram, 1);
            recipe.AddTile(TileID.DemonAltar);
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
