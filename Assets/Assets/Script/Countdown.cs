using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Image _count;
    public float secondtime; // �� ������ �ð� ����

    private float TotalTime; // �� �ð� (�� ����)

    private void Start()
    {
        TotalTime = secondtime * 60f; // ���� �ʷ� ��ȯ
    }

    private void Update()
    {
        
        TotalTime -= Time.deltaTime;
        _count.fillAmount = TotalTime / (secondtime * 60f); // �ð��� �󸶳� ���Ҵ����� ���� fillAmount�� ������Ʈ
        if(TotalTime<=0)
        {
            Time.timeScale = 0;
        }
    }
}
