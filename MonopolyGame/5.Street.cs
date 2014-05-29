using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyGame
{

    public class Street
    //These are all streets and Stations in the game.
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Rent { get; set; }
        public int BoughtBy { get; set; }
        public string Color { get; set; }
        public static Dictionary<int, Street> AllStreets = new Dictionary<int, Street>();
        public Rectangle Rect;


        public Street(int id, string name, int cost, int rent, int boughtby, string color, Rectangle rect)
        {
            this.ID = id;
            this.Name = name;
            this.Cost = cost;
            this.Rent = rent;
            this.BoughtBy = boughtby;
            this.Color = color;
            this.Rect=rect;
        }


        public static void InitializeStreets(int xIncrement, int WINDOW_WIDTH, int WINDOW_HEIGHT)
        {
            AllStreets.Add(1, new Street(1, "OldKentRoad", 60, 2, 0, "brown", new Rectangle(607 - xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607)));
            AllStreets.Add(3, new Street(3, "WhiteChapelRoad", 60, 4, 0, "brown", new Rectangle(607 - 3 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607)));
            AllStreets.Add(5, new Street(5, "KingsCrossStation", 200, 25, 0, "none", new Rectangle(607 - 5 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607)));
            AllStreets.Add(6, new Street(6, "TheAngleIslington", 100, 6, 0, "blue", new Rectangle(607 - 6 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607)));
            AllStreets.Add(8, new Street(8, "EustonRoad", 100, 6, 0, "blue", new Rectangle(607 - 8 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607)));
            AllStreets.Add(9, new Street(9, "PentonvilleRoad", 120, 8, 0, "brown", new Rectangle(607 - 9 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607)));
            AllStreets.Add(11, new Street(11, "PallMall", 140, 10, 0, "pink", new Rectangle(0, 607 - xIncrement, 93, xIncrement)));
            AllStreets.Add(12, new Street(12, "Electro", 150, 50, 0, "none", new Rectangle(0, 607 - 2 * xIncrement, 93, xIncrement)));
            AllStreets.Add(13, new Street(13, "Whitehall", 140, 10, 0, "pink", new Rectangle(0, 607 - 3 * xIncrement, 93, xIncrement)));
            AllStreets.Add(14, new Street(14, "NorthumberlandAvenue", 160, 12, 0, "pink", new Rectangle(0, 607 - 4 * xIncrement, 93, xIncrement)));
            AllStreets.Add(15, new Street(15, "MaryleboneStation", 200, 25, 0, "none", new Rectangle(0, 607 - 5 * xIncrement, 93, xIncrement)));
            AllStreets.Add(16, new Street(16, "BowStreet", 180, 14, 0, "orange", new Rectangle(0, 607 - 6 * xIncrement, 93, xIncrement)));
            AllStreets.Add(18, new Street(18, "MarlboroughStreet", 180, 14, 0, "orange", new Rectangle(0, 607 - 8 * xIncrement, 93, xIncrement)));
            AllStreets.Add(19, new Street(19, "VineStreet", 200, 16, 0, "orange", new Rectangle(0, 607 - 9 * xIncrement, 93, xIncrement)));
            AllStreets.Add(21, new Street(21, "Strand", 220, 18, 0, "red", new Rectangle(93, 0, xIncrement, 93)));
            AllStreets.Add(23, new Street(23, "FleetStreet", 220, 18, 0, "red", new Rectangle(93 + 2 * xIncrement, 0, xIncrement, 93)));
            AllStreets.Add(24, new Street(24, "TrafalgarSquare", 240, 20, 0, "red", new Rectangle(93 + 3 * xIncrement, 0, xIncrement, 93)));
            AllStreets.Add(25, new Street(25, "FenchurchStation", 200, 25, 0, "none", new Rectangle(93 + 4 * xIncrement, 0, xIncrement, 93)));
            AllStreets.Add(26, new Street(26, "LeicesterSquare", 260, 22, 0, "yellow", new Rectangle(93 + 5 * xIncrement, 0, xIncrement, 93)));
            AllStreets.Add(27, new Street(27, "CoventryStreet", 260, 22, 0, "yellow", new Rectangle(93 + 6 * xIncrement, 0, xIncrement, 93)));
            AllStreets.Add(28, new Street(28, "Water", 150, 50, 0, "none", new Rectangle(93 + 7 * xIncrement, 0, xIncrement, 93)));
            AllStreets.Add(29, new Street(29, "Picadilly", 280, 24, 0, "yellow", new Rectangle(93 + 8 * xIncrement, 0, xIncrement, 93)));
            AllStreets.Add(31, new Street(31, "RegentStreet", 300, 26, 0, "green", new Rectangle(607, 93, 93, xIncrement)));
            AllStreets.Add(32, new Street(32, "OxfordStreet", 300, 26, 0, "green", new Rectangle(607, 93 + xIncrement, 93, xIncrement)));
            AllStreets.Add(34, new Street(34, "BondStreet", 320, 28, 0, "green", new Rectangle(607, 93 + 3 * xIncrement, 93, xIncrement)));
            AllStreets.Add(35, new Street(35, "LiverpoolStation", 200, 25, 0, "none", new Rectangle(607, 93 + 4 * xIncrement, 93, xIncrement)));
            AllStreets.Add(37, new Street(37, "ParkLane", 350, 35, 0, "purple", new Rectangle(607, 93 + 6 * xIncrement, 93, xIncrement)));
            AllStreets.Add(39, new Street(39, "Mayfair", 400, 50, 0, "purple", new Rectangle(607, 93 + 8 * xIncrement, 93, xIncrement)));
        }

        //public void InitializeStreets()
        //{
        //    Street OldKentRoad =          new Street(1, "OldKentRoad", 60, 2, false, "brown");
        //    Street WhiteChapelRoad =      new Street(3, "WhiteChapelRoad", 60, 4, false, "brown");
        //    Street KingsCrossStation =    new Street(5, "KingsCrossStation", 200, 25, false, "none");
        //    Street TheAngelIslington =    new Street(6, "TheAngleIslington", 100, 6, false, "blue");
        //    Street EustonRoad =           new Street(8, "EustonRoad", 100, 6, false, "blue");
        //    Street PentonvilleRoad =      new Street(9, "PentonvilleRoad", 120, 8, false, "brown");
        //    Street PallMall =             new Street(11, "PallMall", 140, 10, false, "pink");
        //    Street Whitehall =            new Street(13, "Whitehall", 140, 10, false, "pink");
        //    Street NorthumberlandAvenue = new Street(14, "NorthumberlandAvenue", 160, 12, false, "pink");
        //    Street MaryleboneStation =    new Street(15, "MaryleboneStation", 200, 25, false, "none");
        //    Street BowStreet =            new Street(16, "BowStreet", 180, 14, false, "orange");
        //    Street MarlboroughStreet =    new Street(18, "MarlboroughStreet", 180, 14, false, "orange");
        //    Street VineStreet =           new Street(19, "VineStreet", 200, 16, false, "orange");
        //    Street Strand =               new Street(21, "Strand", 220, 18, false, "red");
        //    Street FleetStreet =          new Street(23, "FleetStreet", 220, 18, false, "red");
        //    Street TrafalgarSquare =      new Street(24, "TrafalgarSquare", 240, 20, false, "red");
        //    Street FenchurchStation =     new Street(25, "FenchurchStation", 200, 25, false, "none");
        //    Street LeicesterSquare =      new Street(26, "LeicesterSquare", 260, 22, false, "yellow");
        //    Street CoventryStreet =       new Street(27, "CoventryStreet", 260, 22, false, "yellow");
        //    Street Picadilly =            new Street(29, "Picadilly", 280, 24, false, "yellow");
        //    Street RegentStreet =         new Street(31, "RegentStreet", 300, 26, false, "green");
        //    Street OxfordStreet =         new Street(32, "OxfordStreet", 300, 26, false, "green");
        //    Street BondStreet =           new Street(34, "BondStreet", 320, 28, false, "green");
        //    Street LiverpoolStation =     new Street(35, "LiverpoolStation", 200, 25, false, "none");
        //    Street ParkLane =             new Street(37, "ParkLane", 350, 35, false, "purple");
        //    Street Mayfair =              new Street(39, "Mayfair", 400, 50, false, "purple");
        //}
    }
}