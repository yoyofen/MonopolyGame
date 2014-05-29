using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyGame
{
    class TileOwnNotifications
    {
        public Texture2D sprite;
        public Rectangle rect;
        public bool Active;



        public TileOwnNotifications(ContentManager content, string spriteName, int x, int y, bool active)
        {
            this.Active = active;
            LoadContent(content, spriteName, x, y);
        }

        private void LoadContent(ContentManager content, string spriteName, int x, int y)
        {
            sprite = content.Load<Texture2D>(spriteName);
            rect = new Rectangle(x, y, 15, 15);
        }
        public void Draw(SpriteBatch spritebatch)
        {
            if (Active)
            {
                spritebatch.Draw(sprite, rect, Color.White);
            }
        }
        public void SetSprite(ContentManager content, string spriteName)
        {
            sprite = content.Load<Texture2D>(spriteName);
        }
    }
}
