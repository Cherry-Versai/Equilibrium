using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace EquilibriumMod.Projectiles
{
    public class TerraspinProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Terraspin"); //
        }

        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 22;
            projectile.aiStyle = 3;
            projectile.melee = true;
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.penetrate = -1;
        }
        public override void AI()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 61, 0f, 0f, 50, default(Color), 2f);
            Main.dust[dust].noGravity = true;
        }

        public override void ModifyDamageHitbox(ref Rectangle hitbox)
        {
            hitbox.Width = 44;
            hitbox.Height = 44;
        }

        /*public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Player player = Main.player[projectile.owner];
            if (player.velocity.Y != 0)
            {
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 15, 0, mod.ProjectileType("Terrawind"), 70, 10, Main.myPlayer);
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, -15, 0, mod.ProjectileType("Terrawind"), 70, 10, Main.myPlayer);
            }
			return false;
        }*/

    }
}