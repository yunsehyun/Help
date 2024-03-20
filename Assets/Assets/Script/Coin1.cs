using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin1 : MonoBehaviour
{
    public int coin;
    private void Awake()
    {
        if(Random.Range(0f, 1f)<0.5f)
        {
            this.gameObject.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        transform.rotation *= Quaternion.Euler(0f, 1f, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        CoinManager coinManager = FindAnyObjectByType<CoinManager>();
        if(other.CompareTag("PC"))
        {
            coinManager.AddCoins(coin);
            this.gameObject.SetActive(false);
        }
    }
}
