using Assets.C_.LoadJS;
using Assets.C_.LoadJS.myLevel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Refresh : MonoBehaviour {
    public Text t;
    Slider gb;
    float time=0;
    // Use this for initialization
    void Start () {
        gb = GameObject.Find("Slider1").GetComponent<Slider>();
        myLevel ml = new myLevel("1");
        ml.Load();
        int level = ml.load.Level;

        if (level > 0)
        {
            InvokeRepeating("run", 0, 0.01f);
            gb.maxValue = 2;
        }
    }
    void run()
    {
        if (time >= 2)
        {
            time = 0;
            gb.value = 0;
        }
        time += 0.01f;
        gb.value = time;

    }
    // Update is called once per frame
    void Update () {
        myCashJS lj = new myCashJS();
        lj.Load();

        t.text = lj.load.cash.ToString();

    }
}
