using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject _store;
    public GameObject _time;
    public void Load()
    {
        Time.timeScale = 1;
        _store.SetActive(false);
        _time.SetActive(true);
    }
    public void Road()
    {
        Time.timeScale = 0;
        _store.SetActive(true);
    }
}
