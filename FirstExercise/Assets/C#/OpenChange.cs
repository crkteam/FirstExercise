using Assets.C_.Character;
using Assets.C_.LoadJS;
using Assets.C_.LoadJS.myLevel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenChange 
{
    public void SetStatus() {
        SetStatus st = new SetStatus(); //啟用 設定狀態
        st.Set("1"); //對第一項
        st.Set("2");
        st.Set("3");
        st.Set("4");
        st.Set("5");
        st.Set("6");
        st.Set("7");
        st.Set("8");
    }

    public void initialization() {
        myCashJS mj = new myCashJS();
        myLevel m1 = new myLevel("1");
        myLevel m2 = new myLevel("2");
        myLevel m3 = new myLevel("3");
        myLevel m4 = new myLevel("4");
        myLevel m5 = new myLevel("5");
        myLevel m6 = new myLevel("6");
        myLevel m7 = new myLevel("7");
        myLevel m8 = new myLevel("8");

        mj.Save(0);

        m1.Save(1);
        m2.Save(0);
        m3.Save(0);
        m4.Save(0);
        m5.Save(0);
        m6.Save(0);
        m7.Save(0);
        m8.Save(0);
    }




}
