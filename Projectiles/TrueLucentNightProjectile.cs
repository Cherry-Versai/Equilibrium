using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Equilibrium.Projectiles
{
    public class TrueLucentNightProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("True Lucent Night"); //
        }

        public override void SetDefaults()
        {
            projectile.width = 26;
            projectile.height = 32;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.penetrate = 3;
            projectile.usesIDStaticNPCImmunity = true;
        }

        public override void AI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 74, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, default(Color), 1);
            Main.dust[dust].noGravity = true;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            for (int i = 0; i < 3; i++)
            {
                float speedX = -projectile.velocity.X * Main.rand.NextFloat(.3f, .6f) + Main.rand.NextFloat(-3f, 3f);
                float speedY = -projectile.velocity.Y * Main.rand.Next(30, 60) * 0.01f + Main.rand.Next(-10, 10) * 0.4f;
                Projectile.NewProjectile(projectile.position.X + speedX, projectile.position.Y + speedY, speedX, speedY, (mod.ProjectileType("CrescentBeam")), (int)(projectile.damage * 0.5), 0f, projectile.owner, 0f, 0f);
            }
        }
    }
}
