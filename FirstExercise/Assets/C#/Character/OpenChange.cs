using Assets.C_.Character;
using Assets.C_.LoadJS.myLevel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenChange : MonoBehaviour {
    public Text upgrade;
    public Text level;
	// Use this for initialization
	void Start () {
        myLevel ml = new myLevel("1");
        ml.Load();
        level.text=ml.load.Level.ToString();
        Convert con = new Convert();
        int bottle = con.cash(ml.load.Level);
        upgrade.text = bottle.ToString();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
