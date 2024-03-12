using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject _store;
    public void Load()
    {
        Time.timeScale = 1;
        _store.SetActive(false);
    }
}
