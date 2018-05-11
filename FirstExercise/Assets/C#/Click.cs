using Assets.C_.LoadJS;
using Assets.C_.LoadJS.myLevel;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour {

    int cash;
    public int num;
    public Text t;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }

    public void save() {
        myCashJS lj = new myCashJS();
        lj.Load();
        myLevel ml = new myLevel("1");
        ml.Load();
        num = ml.load.Level+1;
        this.cash = lj.load.cash;
        this.cash += num;

        lj.Save(this.cash);
    }
}
