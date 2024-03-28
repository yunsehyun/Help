using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    PlayerCarMove playercarmove;
    public List<int> _speed = new List<int>();
    private int[] temp=new int[3];

    public void Awake()
    {
        playercarmove=FindAnyObjectByType<PlayerCarMove>();
        if(Random.Range(0,1f)<0.5f)
        {
            this.gameObject.SetActive(false);
        }
    }

    public void FixedUpdate()
    {
        transform.rotation *= Quaternion.Euler(0,0,1f);
    }

    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("트리거 발동");
        if (other.CompareTag("PC"))
        {
            Debug.Log("부스트 작동함");

            temp[0] = playercarmove.speed;
            temp[1] = playercarmove.maxAccel;
            temp[2] = playercarmove.maxSpeed;
            playercarmove.speed += _speed[0];
            playercarmove.maxAccel += _speed[1];
            playercarmove.maxSpeed += _speed[2];
            Invoke("Swap", 2f);
            this.gameObject.SetActive(false);
        }
    }

    private void Swap()
    {
        playercarmove.speed = temp[0];
        playercarmove.maxAccel = temp[1];
        playercarmove.maxSpeed = temp[2];
    }
}
