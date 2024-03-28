using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDE : MonoBehaviour
{
    private void Awake()
    {
        var obj = FindObjectsOfType<DDE>();
        if(obj.Length==1)
            DontDestroyOnLoad(this.gameObject);
        else
            Destroy(this.gameObject);
    }
}
