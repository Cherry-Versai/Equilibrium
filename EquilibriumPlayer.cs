using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Equilibrium
{
   public class EquilibriumPlayer : ModPlayer
    {
        public override void PostUpdateEquips()
        {
            if (player.HasItem(mod.ItemType("AntiVenomScissors")))
            {
                player.buffImmune[BuffID.Venom] = true;
                player.buffImmune[BuffID.Webbed] = true;
            }
            if (player.HasItem(mod.ItemType("ContactLenses")))
            {
                player.buffImmune[BuffID.Blackout] = true;
                player.buffImmune[BuffID.Obstructed] = true;
            }
            if (player.HasItem(mod.ItemType("DeadSkin")))
            {
                player.buffImmune[BuffID.Ichor] = true;
            }
            if (player.HasItem(mod.ItemType("EbonyFabric")))
            {
                player.buffImmune[BuffID.CursedInferno] = true;
            }
            if (player.HasItem(mod.ItemType("MagneticSoles")))
            {
                player.buffImmune[BuffID.VortexDebuff] = true;
            }
            if (player.HasItem(mod.ItemType("RubberGloves")))
            {
                player.buffImmune[BuffID.Electrified] = true;
            }
        }
    }
}