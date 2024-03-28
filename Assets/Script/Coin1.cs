using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin1 : MonoBehaviour
{
    public int coin;
    AudioSource _eat;
    public AudioClip _clip;
    private void Awake()
    {
        _eat = GetComponent<AudioSource>();
        _eat.clip = _clip;
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
        Debug.Log("코인 발동");
        CoinManager coinManager = FindAnyObjectByType<CoinManager>();
        _eat.Play();
        if(other.CompareTag("PC"))
        {
            coinManager.AddCoins(coin);
            this.gameObject.SetActive(false);
        }
    }
}
