using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtRoad : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        MinusManager wheel = FindAnyObjectByType<MinusManager>();
        Smanager smanager = FindAnyObjectByType<Smanager>();
        PlayerCarMove playercarmove = FindAnyObjectByType<PlayerCarMove>();
        if (other.CompareTag("PC"))
        {
            if (smanager._Stage[0])
            {
                if (wheel.wheel[0])
                {
                    Debug.Log("아무일도 없었다.");
                }
                else
                {
                    playercarmove.maxSpeed -= 5;
                }
            }
            if (smanager._Stage[1])
            {
                if (wheel.wheel[1])
                {
                    Debug.Log("아무일도 없었다.");
                }
                else
                {
                    playercarmove.maxSpeed -= 5;
                }
            }
            if (smanager._Stage[2])
            {
                if (wheel.wheel[2])
                {
                    Debug.Log("아무일도 없었다.");
                }
                else
                {
                    playercarmove.maxSpeed -= 5;
                }
            }
        }
    }
}
