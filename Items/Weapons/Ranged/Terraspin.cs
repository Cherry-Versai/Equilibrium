using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EquilibriumMod.Items.Weapons
{
    public class Terraspin : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terraspin");
            Tooltip.SetDefault("'Aerokinesis'");
        }

        public override void SetDefaults()
        {
            item.damage = 90;
            item.melee = true;
            item.width = 44;
            item.height = 44;
            item.useTime = 15;
            item.useAnimation = 15;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 15;
            item.value = Item.sellPrice(0, 20, 0, 0);
            item.rare = 8;
            item.shootSpeed = 15f;
            item.shoot = mod.ProjectileType("TerraspinProjectile");
            item.UseSound = SoundID.DD2_BookStaffCast;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("TrueLightDisc"));
            recipe.AddIngredient(mod.ItemType("TrueBloodVessel"));
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("TrueLightDisc"));
            recipe.AddIngredient(mod.ItemType("TrueLucentNight"));
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
