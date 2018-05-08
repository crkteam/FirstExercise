using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustTest : MonoBehaviour {
    public void toZero() {
        LoadJS lj = new LoadJS();
        lj.Save(0);
    }
}
