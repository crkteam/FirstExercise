﻿using Assets.C_.LoadJS;
using Assets.C_.LoadJS.myLevel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstOpen : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        string FileName = Application.persistentDataPath+"/myCash";
        if (System.IO.File.Exists(FileName))
        {
            return;
        }
        else
        {
             myCashJS mj = new myCashJS();
             myLevel m1 = new myLevel("1");
             myLevel m2 = new myLevel("2");
             myLevel m3 = new myLevel("3");
             myLevel m4 = new myLevel("4");
             myLevel m5 = new myLevel("5");
             myLevel m6 = new myLevel("6");
             myLevel m7 = new myLevel("7");
             myLevel m8 = new myLevel("8");
        
             mj.Save(0);

             m1.Save(0);
             m2.Save(0);
             m3.Save(0);
             m4.Save(0);
             m5.Save(0);
             m6.Save(0);
             m7.Save(0);
             m8.Save(0); 
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
