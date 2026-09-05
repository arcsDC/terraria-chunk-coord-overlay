using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ChunkCoordOverlay
{
    public class ChunkCoordOverlayMod : Mod
    {
        public override void DrawInterface()
        {
            if (Main.gameMenu || !Main.LocalPlayer.active)
                return;

            int chunkX = Main.LocalPlayer.position.X / 16;
            int chunkY = Main.LocalPlayer.position.Y / 16;
            string text = $"Chunk: {chunkX}, {chunkY}";

            Vector2 size = Main.font.MouseMeasureString(text);
            Vector2 pos = new Vector2(10, 10);

            Main.drawInterfaceBlackBackground = true;
            Rectangle bg = new Rectangle((int)pos.X - 4, (int)pos.Y - 4, (int)size.X + 8, (int)size.Y + 8);
            Main.drawInterfaceBlackBackground = false;

            Main.spriteBatch.Draw(
                TextureAssets.UI[0],
                bg,
                Color.Black * 0.5f
            );

            Main.spriteBatch.DrawString(
                Main.font.Mouse,
                text,
                pos,
                Color.White
            );
        }
    }
}
