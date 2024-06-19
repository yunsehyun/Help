using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Smanager : MonoBehaviour
{
    public bool[] _Stage=new bool[3];
    private void Awake()
    {
        string Sbool= SceneManager.GetActiveScene().name;
        Debug.Log(Sbool.ToString());
        if( Sbool == "Desert")
        {
            _Stage[0] = true;
        }
        if (Sbool == "Mountain")
        {
            _Stage[1] = true;
        }
        if (Sbool == "City")
        {
            _Stage[2] = true;
        }
    }
}
