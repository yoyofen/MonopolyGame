using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyGame
{
    /// <summary>
    /// Class for the player pawn
    /// </summary>
    class Player
    {
        #region Fields

        public string ID { get; private set; } 

        Texture2D sprite;

        public Rectangle rect;

        public int money { get; set; }

        Vector2 velocity=new Vector2(50,50);
        public int currPosition{get;set;}


        public bool isInJail;

        #endregion

        public Player(ContentManager content, string spriteName, int x, int y,Vector2 v, int currPos, int money, bool isInJail)
        {
            LoadContent(content, spriteName, x, y);
            this.isInJail = false;
            this.currPosition = SimpleCards.AllSimpleCards[0].ID;
            this.velocity = v;
            this.currPosition = currPos;
            this.money = money;
            this.isInJail = isInJail;
        }

        public void Move(Rectangle target, Player player)
        {
            if (player.rect.Y>606 && player.rect.X>30)
            {
                player.rect.X-=(int)velocity.X; 
            }
            else if (player.rect.X<=50 && player.rect.Y>30)
            {
                player.rect.Y -= (int)velocity.Y;
            }
            else if (player.rect.Y <= 50 && player.rect.X < 650)
            {
                player.rect.X += (int)velocity.X;
            }
            else if (player.rect.X >= 620 && player.rect.Y < 680)
            {
                player.rect.Y += (int)velocity.Y;
            }
        }
        public void Update(ref int i, Rectangle rect,Player p1)
        {

            if (!rect.Contains(p1.rect))
            {
                Move(rect, p1);
            }
            else
            {
                i = 0;
                p1.rect.X = rect.X + rect.Width / 2 - p1.rect.Width/2;
                p1.rect.Y = rect.Y + rect.Height / 2 - p1.rect.Height/2;
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, rect, Color.White);
        }
        private void LoadContent(ContentManager contentManager, string spriteName, int x, int y)
        {
            // load content and set remainder of draw rectangle
            sprite = contentManager.Load<Texture2D>(spriteName);
            rect = new Rectangle(x, y, 30, 30);
        }
        public static void InitializePlayers()
        {
         
        }
      }
}
