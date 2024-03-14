using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusManager : MonoBehaviour
{
    static public int minus;
    public GameObject _really;


    public void Minus()
    {
        CoinManager coinManager=FindAnyObjectByType<CoinManager>();
        if (coinManager.credits >= minus)
        {
            coinManager.MinusCoins(minus);
            _really.SetActive(false);
        }
    }
}
