using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.C_.Character
{
    public class myConvert
    {
        public int cash(int i, string value)
        {
            int open = 0; ;
            int coefficient = 0;
            int[] tmp = new int[i+2];

            switch (value) {
                case "1":
                    open = 20;
                    coefficient = 2;
                    break;
                case "2":
                    open = 750;
                    coefficient = 3;
                    break;
                case "3":
                    open = 40000;
                    coefficient = 30;
                    break;
                case "4":
                    open = 1500;
                    coefficient = 3;
                    break;
                case "5":
                    open = 1500;
                    coefficient = 3;
                    break;
                case "6":
                    open = 1500;
                    coefficient = 3;
                    break;
                case "7":
                    open = 1500;
                    coefficient = 3;
                    break;
                case "8":
                    open = 1500;
                    coefficient = 3;
                    break;
            }
            tmp[0] = open;
            tmp[1] = open;
            
                for (int j = 2; j < tmp.Length; j++)
                {
                    int lastcash = tmp[j - 1];
                    tmp[j] = lastcash + (int)(coefficient * Math.Sqrt(lastcash));
                }
            


            return tmp[i];
        }

        
    }
}
