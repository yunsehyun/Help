using System.Collections;
using System.Collections.Generic;
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
    public List<GameObject> _items= new List<GameObject>();
    public GameObject ainavmesh;
    Smanager _smanager;
    int cnt=0;
    Countdown _count;

    private void Start()
    {
       _count = FindAnyObjectByType<Countdown>();
        ainavmesh = GetComponent<GameObject>();
        _smanager= FindAnyObjectByType<Smanager>();
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
        //GameStart gamestart = FindAnyObjectByType<GameStart>();
        //gamestart.cnt = 5.5f;
        //_GameStart[0].SetActive(true);
        //_GameStart[1].SetActive(false);
        //Debug.Log("ġƮ F3�� �۵���");
        //car[0].transform.position = CheatPOS[0].position;
        //car[1].transform.position = CheatPOS[1].position;
        //_count.TotalTime = _count.secondtime*60;
        //ainavmesh.SetActive(false);
        //Invoke("Live", 5.5f);
        //foreach(var item in _items)
        //{
        //    if (Random.Range(0, 1f) < 0.5f)
        //    {
        //        item.SetActive(true);
        //    }
        //    else
        //    {
        //        item.SetActive(false);
        //    }
        //}
        if (_smanager._Stage[0])
        {
            SceneManager.LoadScene("Desert");
        }
        if (_smanager._Stage[1])
        {
            SceneManager.LoadScene("Mountain");
        }
        if (_smanager._Stage[2])
        {
            SceneManager.LoadScene("City");
        }
    }
    void cheatF4()
    {
        Debug.Log("ġƮ F4�� �۵���");
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
        Debug.Log("ġƮ F5�� �۵���");
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
