using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
using Unity.VisualScripting;

public class Cheat : MonoBehaviour
{
    public List<Transform> CheatPOS= new List<Transform>();
    public List<GameObject> car= new List<GameObject>();
    public List<GameObject> _GameStart= new List<GameObject>();
    public GameObject _cheatItems;
    public GameObject _cheaetStore;
    public GameObject _time;
    public GameObject _Stop;
    public List<GameObject> _items= new List<GameObject>();
    public GameObject ainavmesh;
    public string _scene;
    int cnt=0;
    Countdown _count;

    private void Start()
    {
       _count = FindAnyObjectByType<Countdown>();
        ainavmesh = GetComponent<GameObject>();
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
        GameStart gamestart = FindAnyObjectByType<GameStart>();
        gamestart.cnt = 5.5f;
        _GameStart[0].SetActive(true);
        _GameStart[1].SetActive(false);
        Debug.Log("치트 F3번 작동함");
        car[0].transform.position = CheatPOS[0].position;
        car[1].transform.position = CheatPOS[1].position;
        _count.TotalTime = _count.secondtime*60;
        ainavmesh.SetActive(false);
        Invoke("Live", 5.5f);
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
        Debug.Log("치트 F4번 작동함");
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
    void Live()
    {
        ainavmesh.SetActive(true);
    }
}
