using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Test : MonoBehaviour
{
    public TMP_InputField[] input;
    public TextMeshProUGUI[] rankText;
    int[] all = new int[5];
    static public int i = 0;

    private void Start()
    {
        for (int j = 0; j < 5; j++)
        {
            string playerName = PlayerPrefs.GetString("PlayerName" + j, "Unknown");
            int desertWin = PlayerPrefs.GetInt("PlayerdesertWin" + j, 0);
            int mountainWin = PlayerPrefs.GetInt("PlayermountainWin" + j, 0);
            int cityWin = PlayerPrefs.GetInt("PlayercityWin" + j, 0);
        }
    }
    public void DisplayRanking()
    {
        for (int j = 0; j < 5; j++)
        {
            string playerName = PlayerPrefs.GetString("PlayerName" + j, "Unknown");
            int desertWin = PlayerPrefs.GetInt("PlayerdesertWin" + j, 0);
            int mountainWin = PlayerPrefs.GetInt("PlayermountainWin" + j, 0);
            int cityWin = PlayerPrefs.GetInt("PlayercityWin" + j, 0);
            all[j] += desertWin + mountainWin + cityWin;
        }

        Array.Sort(all);

        
    }

    private void Update()
    {
        if (i == 5)
        {
            i--;
        }
    }

}
