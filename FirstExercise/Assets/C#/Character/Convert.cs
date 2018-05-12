using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.C_.Character
{
    class Convert
    {
        public int cash(int i)
        {
            int[] tmp = new int[i+2];
            tmp[0] = 20;
            tmp[1] = 20;
            
                for (int j = 2; j < tmp.Length; j++)
                {
                    int lastcash = tmp[j - 1];
                    tmp[j] = lastcash + (int)(2 * Math.Sqrt(lastcash));
                }
            


            return tmp[i];
        }
    }
}
