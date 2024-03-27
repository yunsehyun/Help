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
        for(int i=0;i<2;i++)
            canvas[i].SetActive(false);
        coinmanager = FindAnyObjectByType<CoinManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PC"))
        {
            Debug.Log("½Â¸®");
            canvas[0].SetActive(true);
            coinmanager.AddCoins(5000000);
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

        SceneManager.LoadScene(_scene);
    }
}
 