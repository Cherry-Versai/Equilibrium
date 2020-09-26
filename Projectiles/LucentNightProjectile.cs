using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace EquilibriumMod.Projectiles
{
    public class LucentNightProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Lucent Night"); //
        }

        public override void SetDefaults()
        {
            projectile.width = 24;
            projectile.height = 32;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.usesLocalNPCImmunity = true;
        }

        public override void AI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 272, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, default(Color), 1);
            Main.dust[dust].noGravity = true;
        }
    }
}