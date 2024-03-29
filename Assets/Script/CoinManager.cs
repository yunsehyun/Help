using TMPro;
using UnityEngine;

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
    }

    private void FixedUpdate()
    {
        UpdateUI();
    }

    public void AddCoins(int amount)
    {
        credits += amount;
        UpdateUI();
    }

    public void MinusCoins(int amount)
    {
        credits -= amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        creditText.text = credits.ToString() + "��\n" + wheel.ToString() + "\n" + engine.ToString();
    }
}
