using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyGame
{
   public class ChanceCards
    {
        public static Random randomGenerator = new Random();
        public int ID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public static Dictionary<int, ChanceCards> AllChanceCards = new Dictionary<int, ChanceCards>();
        public Rectangle Rect;
        public ChanceCards(int id, string name, int number, Rectangle rect)
        {
            ID = id;
            Name = name;
            Number = number;
            this.Rect = rect;
        }

        public static void InitializeChanceCards(int xIncrement, int WINDOW_WIDTH, int WINDOW_HEIGHT)
        {
            AllChanceCards.Add(7, new ChanceCards(7, "Chance7", randomGenerator.Next(1, 7), new Rectangle(607 - 7*xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607)));
            AllChanceCards.Add(2, new ChanceCards(2, "CommunityChest2", randomGenerator.Next(1, 7), new Rectangle(607 - 2*xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607)));
            AllChanceCards.Add(22, new ChanceCards(22, "Chance22", randomGenerator.Next(1, 7), new Rectangle(93 + xIncrement, 0, xIncrement, 93)));
            AllChanceCards.Add(36, new ChanceCards(36, "Chance36", randomGenerator.Next(1, 7), new Rectangle(607, 93 + 5 * xIncrement, 93, xIncrement)));
            AllChanceCards.Add(17, new ChanceCards(17, "CommunityChest17", randomGenerator.Next(1, 7), new Rectangle(0, 607 - 7 * xIncrement, 93, xIncrement)));
            AllChanceCards.Add(33, new ChanceCards(33, "CommunityChest33", randomGenerator.Next(1, 7), new Rectangle(607, 93 + 2 * xIncrement, 93, xIncrement)));
        }
        //public void InitializeChanceCards()
        //{
        //    ChanceCards Chance7 = new ChanceCards(7, "Chance7", randomGenerator.Next(1, 7));
        //    ChanceCards CommunityChest2 = new ChanceCards(2, "CommunityChest2", randomGenerator.Next(1, 7));
        //    ChanceCards Chance22 = new ChanceCards(22, "Chance22", randomGenerator.Next(1, 7));
        //    ChanceCards Chance36 = new ChanceCards(36, "Chance36", randomGenerator.Next(1, 7));
        //    ChanceCards CommunityChest17 = new ChanceCards(17, "CommunityChest17", randomGenerator.Next(1, 7));
        //    ChanceCards CommunityChest33 = new ChanceCards(33, "CommunityChest33", randomGenerator.Next(1, 7));
        //}

        //Here we can add 6 different cards for chance and communitychest
        //Suggestions: GoBackFourSquares, GoToGo, GoToMayfair, BankIsgivingyouMoney=100,YouAreveryPrettyReceive100, Give50totheotherplayer
    }
}
