using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyRace : MonoBehaviour
{
    public List<GameObject> Cars = new List<GameObject>();
    public List<GameObject> canvas = new List<GameObject>();
    CoinManager coinmanager;
    PlayerCarMove playercarmove;
    public string _scene;
    public int money;

    private void Start()
    {
        coinmanager = FindAnyObjectByType<CoinManager>();
        playercarmove=FindAnyObjectByType<PlayerCarMove>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PC"))
        {
            Debug.Log("½Â¸®");
            canvas[0].SetActive(true);
            coinmanager.AddCoins(money);
            Time.timeScale = 0;
        }
        else if(other.CompareTag("Enemy"))
        {
            Time.timeScale = 0;
            canvas[1].SetActive(true);
            Debug.Log("ÆÐ¹è");
        }
    }

    public void Lose()
    {
        SceneManager.LoadScene(_scene);
    }
    public void Win()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(_scene);
    }
}
 