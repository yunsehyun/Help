using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    public GameObject _start;
    public GameObject _startimage;
    public float cnt = 5.5f;
    private void Start()
    {
        _start.SetActive(false);
    }
    private void FixedUpdate()
    {
        cnt -= Time.deltaTime;
        if(cnt<=0)
        {
            _start.SetActive(true);
        }
        if (cnt <= -0.5)
        {
            _startimage.SetActive(false);
        }
    }
}
