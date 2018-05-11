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
        myLevel m3 = new myLevel("3");
        myLevel m4 = new myLevel("4");
        myLevel m5 = new myLevel("5");
        myLevel m6 = new myLevel("6");
        myLevel m7 = new myLevel("7");
        myLevel m8 = new myLevel("8");

        m3.Save(0);
        m4.Save(0);
        m5.Save(0);
        m6.Save(0);
        m7.Save(0);
        m8.Save(0);

    }
}
