using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyRace : MonoBehaviour
{
    public List<GameObject> Cars = new List<GameObject>();
    public List<GameObject> canvas = new List<GameObject>();
    CoinManager coinmanager;
    public string _scene;

    private void Start()
    {
        canvas[0].SetActive(false);
        coinmanager = FindAnyObjectByType<CoinManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PC"))
        {
            Debug.Log("½Â¸®");
            canvas[1].SetActive(true);
            coinmanager.AddCoins(5000000);
        }
        else if(other.CompareTag("Enemy"))
        {
            Time.timeScale = 0;
            canvas[2].SetActive(true);
            Debug.Log("ÆÐ¹è");
        }
    }

    public void Lose()
    {
        SceneManager.LoadScene(_scene);
    }
    public void Win()
    {

        SceneManager.LoadScene(_scene);
    }
}
 