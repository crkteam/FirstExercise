using Assets.C_.Character;
using Assets.C_.LoadJS.myLevel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour {
    public Text Level;
    public Text buy;

    int level;
    public string slevel;
    public void upgrade(){
        myLevel ml = new myLevel(slevel);
        level++;
        ml.Save(level);
        level = ml.load.Level;
        Convert con = new Convert();
        int cash = con.cash(level);
        buy.text = cash.ToString();
    }
    void Update()
    {
        

    }
}
