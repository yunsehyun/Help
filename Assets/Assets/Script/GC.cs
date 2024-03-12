using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GC : MonoBehaviour
{
    private void Awake()
    {
        if (Random.Range(0f, 1f) < 0.5f)
        {
            this.gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PC"))
        {
            // 1000만원 추가
            Destroy(this.gameObject);
        }
    }
}
