﻿using Assets.C_.LoadJS.myLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.UI;
using UnityEngine;

namespace Assets.C_.Character
{
    class SetStatus //專門用來填入 各狀態數值
    {
        public Text level;
        public Text upgrade;
        public void Set(String number) {
            level = GameObject.Find("CharacterLevel"+number).GetComponent<Text>();
            upgrade = GameObject.Find("CharacterButton" + number + " Text").GetComponent<Text>();
            myLevel ml = new myLevel(number);
            ml.Load();
            level.text = ml.load.Level.ToString();
            Convert con = new Convert();
            int bottle = con.cash(ml.load.Level);
            upgrade.text = bottle.ToString();
        }

    }
    }

