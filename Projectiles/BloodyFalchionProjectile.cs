using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EquilibriumMod.Projectiles
{
    public class BloodyFalchionProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("BloodyFalchion"); //
        }

        public override void SetDefaults()
        {
            projectile.width = 25;
            projectile.height = 27;
            projectile.CloneDefaults(ProjectileID.PaladinsHammerFriendly);
            projectile.friendly = true;
            projectile.melee = true;
            projectile.penetrate = -1;
        }

        public override void AI()
        {
            if (Main.rand.Next(3) == 0)
            {
                int num107 = Dust.NewDust(projectile.position, projectile.width, projectile.height, 5, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 0, default, 1.1f);
                if (Main.rand.Next(2) == 0)
                {
                    Main.dust[num107].scale = 0.9f;
                    Dust dust81 = Main.dust[num107];
                    dust81.velocity *= 0.2f;
                }
                else
                {
                    Main.dust[num107].noGravity = true;
                }
            }
        }

        public override void ModifyDamageHitbox(ref Rectangle hitbox)
        {
            hitbox.Width = 50;
            hitbox.Height = 54;
        }

        public override bool? CanCutTiles()
        {
            return true;
        }
    }
}