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
    public ProgressBar(Slider g) {
        s = g;
    }
	// Use this for initialization
	void Start () {

    }
    public void ckick() {
        
    }
    void run() {
        if (time >= 2)
        {
            time = 0;
            s.value = 0;
        }
        time += 0.01f;
        s.value = time;
        
    }
}
