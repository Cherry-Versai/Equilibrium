using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace EquilibriumMod.Projectiles
{
    public class BloodOrb : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 10;
            projectile.height = 16;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.penetrate = 1;
        }

        public override void AI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 169, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, default(Color), 1);
        }
    }
}