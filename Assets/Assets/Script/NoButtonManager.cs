using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoButtonManager : MonoBehaviour
{
    public GameObject _really;

    public void Load()
    {
        _really.SetActive(false);
    }
}
