using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusManager : MonoBehaviour
{
    static int Sonic;
    static public int minus;
    public GameObject _really;
    public bool[] wheel = new bool[3];
    public bool[] engine = new bool[2];

    public void Minus()
    {
        CoinManager coinManager=FindAnyObjectByType<CoinManager>();
        Smanager smanager=FindAnyObjectByType<Smanager>();
        PlayerCarMove playercarmove=FindAnyObjectByType<PlayerCarMove>();
        if (coinManager.credits >= minus)
        {
            if(minus == 2500000)
            {
                coinManager.wheel = "�縷�������";
                if (smanager._Stage[0])
                {
                    wheel[0]= true;
                }
            }
            else if(minus == 5000000)
            {
                coinManager.wheel = "����������";
                if (smanager._Stage[1])
                {
                    wheel[1] = true;
                }
            }
            else if(minus == 7500000)
            {
                coinManager.wheel = "�����������";
                if (smanager._Stage[2])
                {
                    wheel[2] = true;
                }
            }
            else if(minus==20000000)
            {
                coinManager.wheel = "�ְ��� ����";
                wheel[0] = true;
                wheel[1] = true;
                wheel[2] = true;
            }
            if(minus==10000000)
            {
                engine[0] = true;
                coinManager.engine = "6���� ����";
                playercarmove.speed = 400;
                playercarmove.maxSpeed = 25;
                playercarmove.maxAccel = 35;
            }
            else if(minus==15000000)
            {
                engine[1]= true;
                coinManager.engine = "8���� ����";
                playercarmove.speed = 600;
                playercarmove.maxSpeed = 30;
                playercarmove.maxAccel = 40;
            }
            coinManager.MinusCoins(minus);
            _really.SetActive(false);
        }
    }
}
