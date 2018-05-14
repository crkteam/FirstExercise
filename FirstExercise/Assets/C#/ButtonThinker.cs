using Assets.C_.Character;
using Assets.C_.LoadJS;
using Assets.C_.LoadJS.myLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.C_
{
    class ButtonThinker
    {
        public ButtonThinker()
        {

            for (int i = 1; i < 9; i++)
            {
                Button btn = GameObject.Find("Cp" + i + "upButton").GetComponent<Button>();
                
                myLevel ml = new myLevel(i.ToString());
                ml.Load();

                myCashJS mj = new myCashJS();
                mj.Load();

                myConvert con = new myConvert();
                int value = con.cash(ml.load.Level,i.ToString());
                if (mj.load.cash > value)
                {
                    btn.interactable=true;
                }
                else {
                    btn.interactable = false;
                }
            }
        }
    }
}
