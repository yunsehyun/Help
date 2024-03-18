using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public TextMeshProUGUI creditText;
    public int credits;
    public string wheel;
    public string engine;

    private void Start()
    {
        wheel = "기본바퀴";
        engine = "4기통 엔진";
        LoadCoins(); // 게임 시작 시 저장된 코인 수를 불러옵니다.
        UpdateUI(); // UI에 현재 코인 수를 표시합니다.
    }

    public void AddCoins(int amount)
    {
        credits += amount;
        UpdateUI();
        SaveCoins(); // 코인이 추가될 때마다 저장합니다.
    }

    public void MinusCoins(int amount)
    {
        credits -= amount;
        UpdateUI();
        SaveCoins(); // 코인이 감소될 때마다 저장합니다.
    }

    private void UpdateUI()
    {
        creditText.text = credits.ToString() + "원\n" + wheel.ToString() + "\n" + engine.ToString();
    }

    private void SaveCoins()
    {
        PlayerPrefs.SetInt("Credits ", credits);
        PlayerPrefs.Save();
    }

    private void LoadCoins()
    {
        credits = PlayerPrefs.GetInt("Credits", 0); // 저장된 코인 수를 불러옵니다. 저장된 값이 없으면 기본값은 0입니다.
    }
    private void Awakae()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
