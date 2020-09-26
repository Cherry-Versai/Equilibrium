using Terraria;
using Terraria.ModLoader;

namespace EquilibriumMod.Projectiles
{
    public class CrescentBeam : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Crescent Beam"); //
        }

        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 24;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.melee = true;
            projectile.penetrate = 3;
            projectile.alpha = 50;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(39, 600);
        }
    }
}
