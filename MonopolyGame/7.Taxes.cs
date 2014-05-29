using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyGame
{
   public class Taxes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Tax { get; set; }
        public static Dictionary<int, Taxes> AllTaxes = new Dictionary<int, Taxes>();
        public Rectangle Rect;
        public Taxes(int id, string name, int tax, Rectangle rect)
        {
            ID = id;
            Name = name;
            Tax = tax;
            this.Rect = rect;
        }
        public static void InitializeTaxes(int xIncrement, int WINDOW_WIDTH, int WINDOW_HEIGHT)
        {
            AllTaxes.Add(4, new Taxes(4, "IncomeTax200", -200, new Rectangle(607 - 4 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607)));
            AllTaxes.Add(38, new Taxes(38, "SuperTax100", -100, new Rectangle(607, 93 + 7 * xIncrement, 93, xIncrement)));
        }
        //public void InitializeTaxes()
        //{
        //    Taxes Incometax200 = new Taxes(4,"IncomeTax200",-200);
        //    Taxes SuperTax100 = new Taxes(38, "SuperTax100", -100);
        //}
    }
}
