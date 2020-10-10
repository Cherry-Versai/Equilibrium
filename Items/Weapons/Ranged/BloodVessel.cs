using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EquilibriumMod.Items.Weapons
{
    public class BloodVessel : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("BloodVessel"); //
        }

        public override void SetDefaults()
        {
            item.damage = 43;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 15;
            item.useAnimation = 15;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 1, 8, 0);
            item.rare = 3;
            item.shootSpeed = 10f;
            item.shoot = mod.ProjectileType("BloodVesselProjectile");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("TheVein"));
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
