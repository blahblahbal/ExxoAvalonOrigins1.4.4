using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ExxoAvalonOrigins.Rarities;

public class QuibopsRarity : ModRarity
{
    public override Color RarityColor
    {
        get
        {
            var colors = new List<Color> { new(6, 106, 255), new(244, 19, 0) };
            int num = (int)(Main.GlobalTimeWrappedHourly / 2f % colors.Count);
            Color blue = colors[num];
            Color red = colors[(num + 1) % colors.Count];
            return Color.Lerp(blue, red,
                Main.GlobalTimeWrappedHourly % 2f > 1f ? 1f : Main.GlobalTimeWrappedHourly % 1f);
        }
    }

    /// <inheritdoc />
    // no 'lower' tier to go to, so return the type of this rarity.
    public override int GetPrefixedRarity(int offset, float valueMult) => Type;
}
