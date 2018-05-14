using Assets.C_.Character;
using Assets.C_.LoadJS;
using Assets.C_.LoadJS.myLevel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar :MonoBehaviour {
    public float maxtime;
    public Slider sl;
    public string num;
    public void Start()
    {
        myLevel ml = new myLevel(num);
        ml.Load();
        if (ml.load.Level > 0)
        {
            sl.maxValue = this.maxtime;
            InvokeRepeating("run", 0, 0.01f);
        }
    }

    public void run()
    {
        if (sl.value >= maxtime)
        {
            sl.value = 0;
            myLevel ml = new myLevel(num);
            ml.Load();
            myCashJS mc = new myCashJS();
            mc.Load();
            myConvert con = new myConvert();
            float C = con.cash(ml.load.Level, num);
            int D = (int)Mathf.Sqrt(C);
            mc.load.cash += ((int)(C/6)+D);
            Debug.Log((int)(C / 6)+D);
            mc.Save(mc.load.cash);
        }
        sl.value += 0.01f;
    }
}
