using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;



namespace Assets.C_.LoadJS
{
    class myLevelJS : DoLoadJS
    {
        public MainLevel load;
        public override void Load()
        {
            StreamReader gfile = new StreamReader(System.IO.Path.Combine(Application.absoluteURL, "myLevel"));
            string loadJson = gfile.ReadToEnd();
            gfile.Close();

            load = new MainLevel();
            load = JsonUtility.FromJson<MainLevel>(loadJson);
        }
        public override void Save(params int[] value)
        {
            string saveString=null;
           
            MainLevel lv1 = new MainLevel();
            MainLevel lv2 = new MainLevel();
            MainLevel lv3 = new MainLevel();
            MainLevel lv4 = new MainLevel();
            MainLevel lv5 = new MainLevel();
            MainLevel lv6 = new MainLevel();
            MainLevel lv7 = new MainLevel();
            MainLevel lv8 = new MainLevel();




            AllLevel al = new AllLevel();
            al.ML[0]=lv1;
            al.ML[1]=lv2;

            saveString = JsonUtility.ToJson(al);
            StreamWriter file = new StreamWriter(System.IO.Path.Combine(Application.absoluteURL, "myLevel"));
            file.Write(saveString);
            file.Close();
        }
    }
}
