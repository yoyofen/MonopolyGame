using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MonopolyGame
{
   public class Dies
    {
        static Random rnd;
        public int result11 { get; set; }
        public int result1 { get; private set; }
        public int result2 { get; private set; }
        public Dies()
        {
            this.result1 = 0;
            this.result2 = 0;
        }

        public int Roll()
        {
            rnd=new Random();
            result1 = rnd.Next(1, 7);
            result2 = rnd.Next(1, 7);
            int result = result1+result2;
            try
            {
                StreamWriter wrt = new StreamWriter("ROLLS.TXT");
                wrt.WriteLine(result1 + result2);
                wrt.Close();
            }
            catch (Exception)
            {
            
            }
            return result;
        }


    }
}
