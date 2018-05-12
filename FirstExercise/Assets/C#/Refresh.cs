using Assets.C_.LoadJS;
using Assets.C_.LoadJS.myLevel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Refresh : MonoBehaviour {
    Text t;
    // Use this for initialization
    void Start () {
      
    }
    // Update is called once per frame
    void Update () {
        myCashJS lj = new myCashJS();
        lj.Load();
        t = GameObject.Find("Cash").GetComponent<Text>();
        t.text = lj.load.cash.ToString();

    }
}
