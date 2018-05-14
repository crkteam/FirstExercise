using Assets.C_.Character;
using Assets.C_.LoadJS;
using Assets.C_.LoadJS.myLevel;
using UnityEngine;
using System;

public class UpgradeButton : MonoBehaviour {
    public string num;

    public void upgrade(){
        myLevel ml = new myLevel(num); //搜尋目前等級
        ml.Load();
        myCashJS mc = new myCashJS();
        mc.Load();

        myConvert con = new myConvert();
        mc.load.cash -= con.cash(ml.load.Level,num);

        mc.Save(mc.load.cash);
        int level = ml.load.Level;
        level++;
        ml.Save(level);
        SetStatus s1 = new SetStatus();
        s1.Set(num);
    }
    public void prThink() {
        myLevel ml = new myLevel(num); //搜尋目前等級
        ml.Load();
        if (ml.load.Level.Equals(1)) {
            GameObject.Find("Cp" + num + "ProgressBar").GetComponent<ProgressBar>().Start();
        }
    }
}
