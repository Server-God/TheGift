using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TheGift.Projectiles
{
    public class PacManP : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            projectile.name = "PacMan";
            aiType = ProjectileID.ZephyrFish;
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
        }
 
        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false;
            return true;
        }
	}
}
