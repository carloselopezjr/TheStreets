using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using TheStreets.Content.Items.Weapons.Swords;

namespace TheStreets.Content.Items.Consumables{ 


    public class StarterBag : ModItem {
        public override void SetDefaults()
        {
            ItemID.Sets.BossBag[Type] = false;
            Item.maxStack = Item.CommonMaxStack;
            Item.consumable = true;
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.Green;
            Item.expert = false;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void ModifyItemLoot(ItemLoot itemLoot)
        {
            itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BasicSword>(), 1, 1));
            itemLoot.Add(ItemDropRule.Common(ItemID.SilverPickaxe, 1, 1));
            itemLoot.Add(ItemDropRule.Common(ItemID.LifeCrystal, 1, 5, 10));
            itemLoot.Add(ItemDropRule.Common(ItemID.ManaCrystal, 1, 3, 5));
            itemLoot.Add(ItemDropRule.Common(ItemID.WoodenArrow, 1, 100, 200));
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
    




}