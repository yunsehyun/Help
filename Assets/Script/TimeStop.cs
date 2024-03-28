using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStop : MonoBehaviour
{
    

    // Update is called once per frame
    void FixedUpdate()
    {
        Time.timeScale = 0;
    }
}
