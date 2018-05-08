using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Refresh : MonoBehaviour {
    public Text t;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        LoadJS lj = new LoadJS();
        lj.Load();

        t.text = lj.load.cash.ToString();
    }
}
