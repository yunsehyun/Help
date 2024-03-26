using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusManager : MonoBehaviour
{
    static int Sonic;
    static public int minus;
    public GameObject _really;
    public bool[] wheel = new bool[3];


    public void Minus()
    {
        CoinManager coinManager=FindAnyObjectByType<CoinManager>();
        Smanager smanager=FindAnyObjectByType<Smanager>();
        PlayerCarMove playercarmove=FindAnyObjectByType<PlayerCarMove>();
        if (coinManager.credits >= minus)
        {
            if(minus == 2500000)
            {
                coinManager.wheel = "사막전용바퀴";
                if (smanager._Stage[0])
                {
                    wheel[0]= true;
                }
            }
            else if(minus == 5000000)
            {
                coinManager.wheel = "산악전용바퀴";
                if (smanager._Stage[1])
                {
                    wheel[1] = true;
                }
            }
            else if(minus == 7500000)
            {
                coinManager.wheel = "도심전용바퀴";
                if (smanager._Stage[2])
                {
                    wheel[2] = true;
                }
            }
            else if(minus==20000000)
            {
                coinManager.wheel = "최고성능 바퀴";
                wheel[0] = true;
                wheel[1] = true;
                wheel[2] = true;
                DontDestroyOnLoad(this);
            }
            if(minus==10000000)
            {
                coinManager.engine = "6기통 엔진";
                playercarmove .speed = 400;
                playercarmove.maxSpeed = 25;
            }
            else if(minus==15000000)
            {
                coinManager.engine = "8기통 엔진";
                playercarmove .speed = 600;
                playercarmove .maxSpeed = 30;
            }
            coinManager.MinusCoins(minus);
            _really.SetActive(false);
        }
    }
}
