using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Price : MonoBehaviour
{
    public TextMeshProUGUI _price;


    void Update()
    {
        _price.text = MinusManager.minus.ToString() + "원\n" + "정말로 구매하실겁니까?";
    }
}
