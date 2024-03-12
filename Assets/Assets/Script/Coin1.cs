using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin1 : MonoBehaviour
{
    private void Awake()
    {
        if(Random.Range(0f, 1f)<0.5f)
        {
            this.gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PC"))
        {
            // 100만원 추가
            Destroy(this.gameObject);
        }
    }
}
