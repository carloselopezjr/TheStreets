using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace TheStreets.Content.Hair
{
    public class Locs : ModHair
    {
        public override bool AvailableDuringCharacterCreation => true;

        public override void SetStaticDefaults()
        {
            HairID.Sets.DrawBackHair[Type] = false;
        }
        
    }
}