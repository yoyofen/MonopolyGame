using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyGame
{
    class SimpleCards
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static Dictionary<int, SimpleCards> AllSimpleCards = new Dictionary<int, SimpleCards>();
        public Rectangle rect;
        public SimpleCards(int id,string name,Rectangle rect)
        {
            ID = id;
            this.Name = name;
            this.rect=rect;

        }
        public static void InitializeSimpleCards(int WINDOW_WIDTH, int WINDOW_HEIGHT)
        {
            AllSimpleCards.Add(0, new SimpleCards(0, "Go", new Rectangle(607, 607, WINDOW_WIDTH - 607, WINDOW_HEIGHT - 607)));
            AllSimpleCards.Add(10, new SimpleCards(10, "JailRest",new Rectangle(0,607,93,WINDOW_HEIGHT-607)));
            AllSimpleCards.Add(20, new SimpleCards(20, "Parking", new Rectangle(0, 0, 93, 93)));
            AllSimpleCards.Add(30, new SimpleCards(30, "GoToJail", new Rectangle(607, 0, WINDOW_WIDTH-607, 93)));
           
        }
    }
}
