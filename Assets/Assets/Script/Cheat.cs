using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cheat : MonoBehaviour
{
    public Transform POS;
    public GameObject Playercar;
    public List<GameObject> _GameStart= new List<GameObject>();
    public GameObject _cheatItems;
    public GameObject _cheaetStore;
    public GameObject _time;
    public GameObject _Stop;
    public List<GameObject> _items= new List<GameObject>();
    public string _scene;
    int cnt=0;
    Countdown _count;

    private void Start()
    {
       _count = FindAnyObjectByType<Countdown>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
            cheatF1();
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            cheatF2();
        }
        if(Input.GetKeyDown(KeyCode.F3))
        {
            cheatF3();
        }
        if(Input.GetKeyDown(KeyCode.F4))
        {
            cheatF4();
        }
        if(Input.GetKeyDown(KeyCode.F5))
        {
            cheatF5();
        }
    }
    void cheatF1()
    {
        Debug.Log("ġƮ F1�� �۵���");
        _cheatItems.SetActive(true);
        _time.SetActive(false);
    }
    void cheatF2()
    {
        Debug.Log("ġƮ F2�� �۵���");
        _cheaetStore.SetActive(true);
        _time.SetActive(false);
    }
    void cheatF3()
    {
        GameStart gamestart = FindAnyObjectByType<GameStart>();
        gamestart.cnt = 5.5f;
        _GameStart[0].SetActive(true);
        _GameStart[1].SetActive(false);
        Debug.Log("ġƮ F3�� �۵���");
        Playercar.transform.position=POS.position;
        _count.TotalTime = _count.secondtime*60;
        foreach(var item in _items)
        {
            if (Random.Range(0, 1f) < 0.5f)
            {
                item.SetActive(true);
            }
            else
            {
                item.SetActive(false);
            }
        }
    }
    void cheatF4()
    {
        Debug.Log("ġƮ F4�� �۵���");
    }
    void cheatF5()
    {
        Debug.Log("ġƮ F5�� �۵���");
        cnt++;
        if (cnt % 2 == 1)
        {
            _Stop.SetActive(true);
            Time.timeScale = 0;
        }
        if(cnt%2==0)
        {
            _Stop.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
