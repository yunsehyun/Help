using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject _Store;
    private void Awake()
    {
        _Store.SetActive(false);
    }
}
