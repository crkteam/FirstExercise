using Assets.C_.Character;
using Assets.C_.LoadJS.myLevel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour {

    public void upgrade(){
        myLevel ml = new myLevel("1"); //搜尋目前等級
        ml.Load();
        int level = ml.load.Level;
        level++;
        ml.Save(level);
        SetStatus s1 = new SetStatus();
        s1.Set("1");
        
        UpDecide up = new UpDecide();//調整點擊變數
        up.upgrade();
    }
    void Update()
    {
        

    }
}
