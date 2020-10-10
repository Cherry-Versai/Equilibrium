using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Equilibrium.Projectiles
{
    public class TrueLightDiscProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("True Light Disc"); //
        }

        public override void SetDefaults()
        {
            projectile.width = 36;
            projectile.height = 36;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.localNPCHitCooldown = -1;
            projectile.light = 1f;
        }

        public override void AI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 255, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, default, 1);
            Main.dust[dust].noGravity = true;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Projectile.NewProjectile(projectile.position, projectile.velocity, ProjectileID.CrystalShard, projectile.damage, 0, 255, 0, 0);
        }
    }
}
