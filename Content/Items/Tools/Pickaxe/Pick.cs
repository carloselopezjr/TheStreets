using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheStreets.Content.Items.Tools.Pickaxe
{
    public class Pick : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 4;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 5;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.pick = 50;
            Item.useAnimation = 5;
            Item.knockBack = 3;
            Item.value = Item.buyPrice(silver: 1);
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Green;
            Item.useTurn = true;
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