using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EquilibriumMod.Items.Weapons
{
    public class TrueBloodVessel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Blood Vessel");
            //Tooltip.SetDefault("'Blood circulation'");
        }

        public override void SetDefaults()
        {
            item.damage = 81;
            item.melee = true;
            item.width = 36;
            item.height = 36;
            item.useTime = 15;
            item.useAnimation = 15;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 6.75F;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.rare = 8;
            item.shootSpeed = 15f;
            item.shoot = mod.ProjectileType("TrueBloodVesselProjectile");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("BloodVessel"));
            recipe.AddIngredient(mod.ItemType("BrokenHeroBoomerang"));
            recipe.AddIngredient(ItemID.Ichor, 10);
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
