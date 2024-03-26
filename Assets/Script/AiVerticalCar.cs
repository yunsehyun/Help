using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiVerticalCar : MonoBehaviour
{
    public float speed = 0.5f;
    IMFTri imftri;

    private void Awake()
    {
        imftri = GameObject.FindWithTag("ITF").GetComponent<IMFTri>();
        this.gameObject.SetActive(false);
    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(0, 0, speed);
    }
}
