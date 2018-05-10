using Assets.C_.Character;
using Assets.C_.LoadJS.myLevel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenChange : MonoBehaviour {
	// Use this for initialization
	void Start () {
        SetStatus st = new SetStatus(); //啟用 設定狀態
        st.Set("1"); //對第一項
    }
	
	// Update is called once per frame
	void Update () {
		
	}

}
