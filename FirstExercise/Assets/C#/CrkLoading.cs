using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CrkLoading : MonoBehaviour
{

    public void CrkChangeScene(string name)
    {
        Application.LoadLevel(name);
    }


}