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
        wheel = "�⺻����";
        engine = "4���� ����";
        LoadCoins(); // ���� ���� �� ����� ���� ���� �ҷ��ɴϴ�.
        UpdateUI(); // UI�� ���� ���� ���� ǥ���մϴ�.
    }

    public void AddCoins(int amount)
    {
        credits += amount;
        UpdateUI();
        SaveCoins(); // ������ �߰��� ������ �����մϴ�.
    }

    public void MinusCoins(int amount)
    {
        credits -= amount;
        UpdateUI();
        SaveCoins(); // ������ ���ҵ� ������ �����մϴ�.
    }

    private void UpdateUI()
    {
        creditText.text = credits.ToString() + "��\n" + wheel.ToString() + "\n" + engine.ToString();
    }

    private void SaveCoins()
    {
        PlayerPrefs.SetInt("Credits ", credits);
        PlayerPrefs.Save();
    }

    private void LoadCoins()
    {
        credits = PlayerPrefs.GetInt("Credits", 0); // ����� ���� ���� �ҷ��ɴϴ�. ����� ���� ������ �⺻���� 0�Դϴ�.
    }
    private void Awakae()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
