using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tip : MonoBehaviour
{
    public GameObject _tip;
    public GameObject down;
    private void Start()
    {
        _tip.SetActive(false);
    }
    public void Load()
    {
        _tip.SetActive(true);
    }
    private void Update()
    {
        if (_tip)
        {
            down.SetActive(true);
        }
        else if(_tip==false)
        {
            down.SetActive(false);
        }
    }
}
