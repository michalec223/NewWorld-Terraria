using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace newworld.Items
{
    public class RobesOfAnorak : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.value = 10000;
            Item.rare = -12;
            Item.accessory = true;
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            // grant the player more mana, mana regen and decrease mana usage
            player.statManaMax2 += 400;
            player.manaRegen += 100;
            player.manaCost -= 0.7f;
            
            // stop the player from regenerating mana if they are above 50% mana
            if (player.statMana > player.statManaMax2 * 0.5f)
            {
                player.manaRegen = 0;
            }
            else
            {
                // allow mana regen even if the player is using magic
                player.manaRegenDelay -= player.manaRegenDelay;
            }

            // grant effects of all vanilla magic accessories
            player.manaFlower = true;
            player.magicCuffs = true;
            player.manaMagnet = true;

            // grant armor set effects of nebula armor
            player.setNebula = true;

            // grant the player infinite flight
            player.wingTime = 999999999;
        }


    }
}