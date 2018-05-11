using Assets.C_.Character;
using Assets.C_.LoadJS;
using Assets.C_.LoadJS.myLevel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UpgradeButton : MonoBehaviour {
    public string num;

    public void upgrade(){
        myLevel ml = new myLevel(num); //搜尋目前等級
        ml.Load();
        myCashJS mc = new myCashJS();
        mc.Load();
        Assets.C_.Character.Convert con = new Assets.C_.Character.Convert();
        mc.load.cash -= con.cash(ml.load.Level);
        mc.Save(mc.load.cash);
        int level = ml.load.Level;
        level++;
        ml.Save(level);
        SetStatus s1 = new SetStatus();
        s1.Set(num);
        
      //  UpDecide up = new UpDecide();//調整點擊變數
      //  up.upgrade();
    }
    public void prThink() {
        myLevel ml = new myLevel(num); //搜尋目前等級
        ml.Load();
        if (ml.load.Level.Equals(1)) {
            GameObject.Find("Cp" + num + "ProgressBar").GetComponent<ProgressBar>().Start();
        }
    }
}
