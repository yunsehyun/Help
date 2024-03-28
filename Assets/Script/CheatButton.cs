using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheatButton : MonoBehaviour
{
    public List<GameObject> _buttons = new List<GameObject>();
    public GameObject _store;
    private int[] temp= new int[3];
    CoinManager coinmanager;
    MinusManager allwheel;
    PlayerCarMove playercarmove;

    private void Start()
    {
        foreach (GameObject buttonObject in _buttons)
        {
            Button button = buttonObject.GetComponent<Button>();
            if (button != null)
            {
                button.onClick.AddListener(() => ButtonClick(buttonObject));
            }
            else
            {
                Debug.LogError("Button component not found on object: " + buttonObject.name);
            }
        }
    }

    public void ButtonClick(GameObject buttonClicked)
    {
        coinmanager = FindAnyObjectByType<CoinManager>();
        allwheel = FindAnyObjectByType<MinusManager>();
        playercarmove = FindAnyObjectByType<PlayerCarMove>();

        int index = _buttons.IndexOf(buttonClicked); // 클릭된 버튼의 인덱스 확인

        switch (index)
        {
            case 0:
                Debug.Log("0");
                coinmanager.wheel = "사막전용바퀴";
                allwheel.wheel[0] = true;
                break;
            case 1:
                Debug.Log("1");
                coinmanager.wheel = "산악전용바퀴";
                allwheel.wheel[1] = true;
                break;
            case 2:
                Debug.Log("2");
                coinmanager.wheel = "도심전용바퀴";
                allwheel.wheel[2] = true;
                break;
            case 3:
                Debug.Log("3");
                coinmanager.wheel = "최고성능바퀴";
                allwheel.wheel[0] = true;
                allwheel.wheel[1] = true;
                allwheel.wheel[2] = true;
                break;
            case 4:
                Debug.Log("4");
                coinmanager.engine = "6기통 엔진";
                playercarmove.speed = 400;
                playercarmove.maxSpeed = 25;
                break;
            case 5:
                Debug.Log("5");
                coinmanager.engine = "8기통 엔진";
                playercarmove.speed = 600;
                playercarmove.maxSpeed = 30;
                break;
            case 6:
                coinmanager.AddCoins(1000000);
                break;
            case 7:
                coinmanager.AddCoins(5000000);
                break;
            case 8:
                coinmanager.AddCoins(10000000);
                break;
            case 9:
                Time.timeScale = 0;
                _store.SetActive(true);
                break;
            case 10:
                Time.timeScale = 0;
                temp[0] = playercarmove.speed;
                temp[1] = playercarmove.maxAccel;
                temp[2] = playercarmove.maxSpeed;
                playercarmove.speed += 500;
                playercarmove.maxAccel += 50;
                playercarmove.maxSpeed += 50;
                Invoke("Swap", 2f);
                break;
            case 11:
                Time.timeScale = 0;
                temp[0] = playercarmove.speed;
                temp[1] = playercarmove.maxAccel;
                temp[2] = playercarmove.maxSpeed;
                playercarmove.speed += 1000;
                playercarmove.maxAccel += 100;
                playercarmove.maxSpeed += 100;
                Invoke("Swap", 2f);
                break;
            default:
                break;
        }
    }
    private void Swap()
    {
        playercarmove.speed = temp[0];
        playercarmove.maxAccel = temp[1];
        playercarmove.maxSpeed = temp[2];
    }
}
