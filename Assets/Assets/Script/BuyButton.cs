using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButton : MonoBehaviour
{
    public GameObject _really;
    public int items;
    public void Load()
    {
        MinusManager.minus = items;
        _really.SetActive(true);
    }
}
