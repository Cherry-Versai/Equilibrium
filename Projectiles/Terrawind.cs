using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Equilibrium.Projectiles
{
    public class Terrawind : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Terraspin"); //
        }

        public override void SetDefaults()
        {
            projectile.width = 21;
            projectile.height = 8;
            projectile.aiStyle = 40;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.friendly = true;
            projectile.alpha = 150;
        }
        public override void AI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 63, 0f, 0f, 50, default, 2f);
            Main.dust[dust].noGravity = true;
        }

        public override void ModifyDamageHitbox(ref Rectangle hitbox)
        {
            hitbox.Width = 42;
            hitbox.Height = 16;
        }

    }
}