using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Equilibrium.Projectiles
{
    public class TrueBloodVesselProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("True Blood Vessel"); //
        }

        public override void SetDefaults()
        {
            projectile.width = 36;
            projectile.height = 36;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.penetrate = 1;
        }

        public override void AI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 169, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, default(Color), 1);
            Main.dust[dust].noGravity = true;
            /*for (int i = 0; i < 1; i++)
			{
				float speedX = -projectile.velocity.X;
                float speedY = -projectile.velocity.Y;
                Projectile.NewProjectile(projectile.position.X + speedX, projectile.position.Y + speedY, speedX, speedY, mod.ProjectileType("BloodOrb"), (int)(projectile.damage * 0.5), 0f, projectile.owner, 0f, 0f);
               // Projectile.NewProjectile(projectile.position, projectile.velocity, ProjectileID.GoldenShowerFriendly, 20, 0, 255, 0, 0);
			}*/
        }
    }
}

