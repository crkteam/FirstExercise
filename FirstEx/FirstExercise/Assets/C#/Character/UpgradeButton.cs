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

    }
    void Update()
    {
        myLevel ml = new myLevel(slevel);
        ml.Load();
        level = ml.load.Level;
        Level.text = level.ToString();
        buy.text = level.ToString();
    }
}
