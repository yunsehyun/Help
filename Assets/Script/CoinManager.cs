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
        wheel = "기본바퀴";
        engine = "4기통 엔진";
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
        creditText.text = credits.ToString() + "원\n" + wheel.ToString() + "\n" + engine.ToString();
    }
}
