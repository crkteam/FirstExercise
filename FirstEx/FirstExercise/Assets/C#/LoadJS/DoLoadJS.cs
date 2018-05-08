using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.C_.LoadJS
{
    abstract class DoLoadJS :LaodJs
    {
        public MainPoint load;

        public virtual void Load()
        {
            StreamReader gfile = new StreamReader(System.IO.Path.Combine(Application.absoluteURL, null));
            string loadJson = gfile.ReadToEnd();
            gfile.Close();

            load = new MainPoint();
            load = JsonUtility.FromJson<MainPoint>(loadJson);
        }

        public virtual void Save(params int[] value)
        {
            MainPoint mp = new MainPoint();
            mp.cash = value[0];
            string saveString = JsonUtility.ToJson(mp);

            StreamWriter file = new StreamWriter(System.IO.Path.Combine(Application.absoluteURL, null));
            file.Write(saveString);
            file.Close();
        }
    }
}
