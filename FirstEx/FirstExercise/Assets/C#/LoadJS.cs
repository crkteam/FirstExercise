using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadJS : MonoBehaviour {
    public MainPoint load;
    public void Load() {
        StreamReader gfile = new StreamReader(System.IO.Path.Combine(Application.absoluteURL, "myCash"));
        string loadJson = gfile.ReadToEnd();
        gfile.Close();

        load = new MainPoint();
        load = JsonUtility.FromJson<MainPoint>(loadJson);
    }

    public void Save(int a) {
        MainPoint mp = new MainPoint();
        mp.cash = a;
        string saveString = JsonUtility.ToJson(mp);

        StreamWriter file = new StreamWriter(System.IO.Path.Combine(Application.absoluteURL, "myCash"));
        file.Write(saveString);
        file.Close();
    }
}
