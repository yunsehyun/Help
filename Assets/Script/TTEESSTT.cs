using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TTEESSTT : MonoBehaviour
{
    int[] total = new int[5];
    public TextMeshProUGUI text;
    private void Start()
    {
        for(int i=0;i<5;i++)
        {
            string playerName = PlayerPrefs.GetString("PlayerName" + i, "Unknown");
            int playerdesertwin= PlayerPrefs.GetInt("PlayerDesertWin" + i, 0);
            int playermountainwin = PlayerPrefs.GetInt("PlayerMountainWin" + i, 0);
            int playercitywin = PlayerPrefs.GetInt("PlayerCityWin" + i, 0);
        }
    }

    public void DisplayRanking()
    {
        for(int i=0;i<5;i++)
        {
            for(int j=0;j<5;j++)
            {

            }
        }
    }
}
