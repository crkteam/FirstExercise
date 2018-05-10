using Assets.C_.LoadJS;
using Assets.C_.LoadJS.myLevel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustTest : MonoBehaviour {
    public void toZero() {
       myCashJS lj = new myCashJS();
        lj.Save(0);
        myLevel ml = new myLevel("1");
        ml.Save(0);
    }
    public void justtry() {
        myLevel ml = new myLevel("1");
        ml.Load();

            GameObject.Find("MainClick").GetComponent<Click>().num++;
        Debug.Log(GameObject.Find("MainClick").GetComponent<Click>().num);
    }
}
