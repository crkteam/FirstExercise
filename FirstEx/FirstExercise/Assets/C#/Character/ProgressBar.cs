using Assets.C_.LoadJS.myLevel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {
    public int maxtime;
    float time ;
    public string slevel;
    bool use=false;
    public Slider s;

    int level; //等級超過1等才會開始

	// Use this for initialization
	void Start () {

    }
    public void ckick() {
        myLevel ml = new myLevel(slevel);
        ml.Load();
        level = ml.load.Level;

        if (level > 0)
        {
            InvokeRepeating("run", 0, 0.01f);
            s.maxValue = maxtime;
        }
        
    }
    void run() {
        if (time >= maxtime)
        {
            time = 0;
            s.value = 0;
        }
        time += 0.01f;
        s.value = time;
        
    }
}
