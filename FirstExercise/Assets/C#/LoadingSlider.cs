using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingSlider : MonoBehaviour {
    float t;
    public float maxtime;
    public Slider s;

    void Start()
    {
        InvokeRepeating("a", 0, 0.01f);
        s.maxValue = maxtime;
    }
    public void a()
    {
        if (t >= maxtime)
        {

            t = 0;
            s.value = 0;
        }
        t += 0.01f;
        s.value = t;
        //Debug.Log(t);
    }
    public void TimeChangeScene(string name)
    {
        if (t > maxtime)
        {
            CancelInvoke();
            Application.LoadLevel(name);
        }
    }
}
