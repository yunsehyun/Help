using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cheat : MonoBehaviour
{
    public List<Transform> CheatPOS= new List<Transform>();
    public List<GameObject> car= new List<GameObject>();
    public List<GameObject> _GameStart= new List<GameObject>();
    public GameObject _cheatItems;
    public GameObject _cheaetStore;
    public GameObject _time;
    public GameObject _Stop;
    public int dollar;
    public bool[] __engine = new bool[2];
    public List<GameObject> _items= new List<GameObject>();
    public GameObject ainavmesh;
    MinusManager minusmanager;
    CoinManager coin;
    Smanager _smanager;
    int cnt=0;
    Countdown _count;

    private void Start()
    {
       _count = FindAnyObjectByType<Countdown>();
        ainavmesh = GetComponent<GameObject>();
        _smanager= FindAnyObjectByType<Smanager>();
        minusmanager = FindAnyObjectByType<MinusManager>();
        coin = FindAnyObjectByType<CoinManager>();
        dollar = coin.credits;
        if (minusmanager.engine[0])
            __engine[0] = true;
        if (minusmanager.engine[1])
            __engine[1] = true;
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
        if (Input.GetKeyDown(KeyCode.Home))
        {
            Home();
        }
    }
    void cheatF1()
    {
        Debug.Log("치트 F1번 작동함");
        _cheatItems.SetActive(true);
        _time.SetActive(false);
    }
    void cheatF2()
    {
        Debug.Log("치트 F2번 작동함");
        _cheaetStore.SetActive(true);
        _time.SetActive(false);
    }
    void cheatF3()
    {
        if (_smanager._Stage[0])
        {
            coin.credits = dollar;
            if (__engine[0])
            {
                minusmanager.engine[0] = true;
            }
            else if (__engine[1])
            {
                minusmanager.engine[1] = true;
            }
                SceneManager.LoadScene("Desert");
        }
        if (_smanager._Stage[1])
        {
            coin.credits = dollar;
            SceneManager.LoadScene("Mountain");
        }
        if (_smanager._Stage[2])
        {
            coin.credits = dollar;
            SceneManager.LoadScene("City");
        }
    }
    void cheatF4()
    {
        Debug.Log("치트 F4번 작동함");
        if (_smanager._Stage[0])
        {
            SceneManager.LoadScene("Mountain");
        }
        if (_smanager._Stage[1])
        {
            SceneManager.LoadScene("City");
        }
        if (_smanager._Stage[2])
        {
            SceneManager.LoadScene("Ending");
        }
    }
    void cheatF5()
    {
        Debug.Log("치트 F5번 작동함");
        cnt++;
        if (cnt % 2 == 1)
        {
            _Stop.SetActive(true);
            Time.timeScale = 0;
        }
        if (cnt % 2 == 0)
        {
            _Stop.SetActive(false);
            Time.timeScale = 1;
        }
    }
    void Home()
    {
        Time.timeScale += 1;
    }
    //void Live()
    //{
    //    ainavmesh.SetActive(true);
    //}
}
