using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;


namespace Assets.C_.LoadJS
{
    class myCashJS :DoLoadJS
    {
        public MainPoint load;
        public override void Load()
        {
            StreamReader gfile = new StreamReader(System.IO.Path.Combine(Application.absoluteURL, "myCash"));
            string loadJson = gfile.ReadToEnd();
            gfile.Close();

            load = new MainPoint();
            load = JsonUtility.FromJson<MainPoint>(loadJson);
        }
        public override void Save(params int[] value)
        {
            MainPoint mp = new MainPoint();
            mp.cash = value[0];
            string saveString = JsonUtility.ToJson(mp);

            StreamWriter file = new StreamWriter(System.IO.Path.Combine(Application.absoluteURL,"myCash"));
            file.Write(saveString);
            file.Close();
        }
    }
}
