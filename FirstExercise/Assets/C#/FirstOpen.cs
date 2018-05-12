using Assets.C_.LoadJS;
using Assets.C_.LoadJS.myLevel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstOpen : MonoBehaviour {

    OpenChange oc = new OpenChange();
    // Use this for initialization
    void Awake () {
        string FileName = Application.persistentDataPath+"/myCash";
        if (System.IO.File.Exists(FileName))
        {
            oc.SetStatus();
        }
        else
        {
            oc.initialization();
            oc.SetStatus();
        }
    }
}
