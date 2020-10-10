using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Equilibrium.Items.Accessories.Immunity
{
    public class AntivenomScissors : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Antivenom Scissors");
            Tooltip.SetDefault("Grants immunity to Webbed and Venom");
        }
        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 16;
            item.rare = 1;
            item.accessory = true;
            item.defense = 4;
        }
    }
    public class ContactLenses : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Contact Lenses");
            Tooltip.SetDefault("Grants immunity to Blackout and Obstructed");
        }
        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 16;
            item.rare = 1;
            item.accessory = true;
            item.defense = 4;
        }
    }
    public class DeadSkin : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Inorganic Skin");
            Tooltip.SetDefault("Grants immunity to Ichor");
        }
        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 16;
            item.rare = 1;
            item.accessory = true;
            item.defense = 4;
        }
    }
    public class EbonyFabric : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ebony Fabric");
            Tooltip.SetDefault("Grants immunity to Cursed Inferno");
        }
        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 16;
            item.rare = 1;
            item.accessory = true;
            item.defense = 4;
        }
    }
    public class MagneticSoles : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magnetic Soles");
            Tooltip.SetDefault("Grants immunity to Distorted");
        }
        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 16;
            item.rare = 1;
            item.accessory = true;
            item.defense = 4;
        }
    }
    public class RubberGloves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rubber Gloves");
            Tooltip.SetDefault("Grants immunity to Electrified");
        }
        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 16;
            item.rare = 1;
            item.accessory = true;
            item.defense = 4;
        }
    }
}