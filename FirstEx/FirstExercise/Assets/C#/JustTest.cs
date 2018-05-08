using Assets.C_.LoadJS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustTest : MonoBehaviour {
    public void toZero() {
       myCashJS lj = new myCashJS();
        lj.Save(0);
    }
}
