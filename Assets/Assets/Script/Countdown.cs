using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Image _count;
    public float secondtime; // 초 단위로 시간 설정

    private float TotalTime; // 총 시간 (초 단위)

    private void Start()
    {
        TotalTime = secondtime * 60f; // 분을 초로 변환
    }

    private void Update()
    {
        
        TotalTime -= Time.deltaTime;
        _count.fillAmount = TotalTime / (secondtime * 60f); // 시간이 얼마나 남았는지에 따라 fillAmount를 업데이트
        if(TotalTime<=0)
        {
            Time.timeScale = 0;
        }
    }
}
