using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.C_.LoadJS.myLevel
{
    class myLevel :DoLoadJS
    {
        public String who;
        public MainLevel load;
        public myLevel(String who) {
            this.who = who;
        }
        public override void Load()
        {
            StreamReader gfile = new StreamReader(System.IO.Path.Combine(Application.persistentDataPath, "myLevel"+who));
            string loadJson = gfile.ReadToEnd();
            gfile.Close();

            load = new MainLevel();
            load = JsonUtility.FromJson<MainLevel>(loadJson);
        }
        public override void Save(params int[] value)
        {
            MainLevel mp = new MainLevel();
            mp.Level = value[0];
            string saveString = JsonUtility.ToJson(mp);

            StreamWriter file = new StreamWriter(System.IO.Path.Combine(Application.persistentDataPath, "myLevel"+who));
            file.Write(saveString);
            file.Close();
        }
    }
}
