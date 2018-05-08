using Assets.C_.LoadJS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustTest : MonoBehaviour {
    public void toZero() {
       myCashJS lj = new myCashJS();
        lj.Save(0);
    }
    public void justtry() {
        //myLevelJS ml = new myLevelJS();
        //ml.Save();
        MainLevel ml = new MainLevel();
        ml.Level.Add(10);
        ml.Level.Add(200);
        ml.Level.Add(500);
        ml.Level[0] = 50;
        string saveString = JsonUtility.ToJson(ml);
        Debug.Log(saveString);
    }
}
