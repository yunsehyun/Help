using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cheat : MonoBehaviour
{
    public GameObject Playercar;
    public GameObject _cheaetStore;
    public GameObject _time;
    public string _scene;

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
    }
    void cheatF1()
    {

    }
    void cheatF2()
    {
        _cheaetStore.SetActive(true);
        _time.SetActive(false);
    }
    void cheatF3()
    {
        Destroy(Playercar);
        SceneManager.LoadScene(_scene);
    }
    void cheatF4()
    {

    }
}
