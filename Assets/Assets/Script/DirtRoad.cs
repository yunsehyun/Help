using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtRoad : MonoBehaviour
{
    private int Tmaxspeed,Tspeed;
    private void OnTriggerStay(Collider other)
    {
        MinusManager wmanager = FindAnyObjectByType<MinusManager>();
        Smanager smanager = FindAnyObjectByType<Smanager>();
        PlayerCarMove playercarmove = FindAnyObjectByType<PlayerCarMove>();
        Tmaxspeed = playercarmove.maxSpeed;
        Tspeed=playercarmove.speed;
        if (other.CompareTag("PC"))
        {
            if (smanager._Stage[0])
            {
                if (wmanager.wheel[0]==false)
                {
                    playercarmove.maxSpeed -= 5;
                    playercarmove.speed -= 50;
                }
            }
            if (smanager._Stage[1])
            {
                if (wmanager.wheel[1]==false)
                {
                    playercarmove.maxSpeed -= 5;
                    playercarmove.speed -= 50;
                }
            }
            if (smanager._Stage[2])
            {
                if (wmanager.wheel[2]==false)
                {
                    playercarmove.maxSpeed -= 5;
                    playercarmove.speed -= 50;
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerCarMove playercarmove =FindAnyObjectByType<PlayerCarMove>();
        playercarmove.maxSpeed = Tmaxspeed;
        playercarmove.speed = Tspeed;
    }
}
