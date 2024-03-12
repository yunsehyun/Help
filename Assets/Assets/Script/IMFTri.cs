using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMFTri : MonoBehaviour
{
    public List<GameObject> VertCars;
    public bool _IMFTrigger=false;
    private void OnTriggerEnter(Collider other)
    {
        _IMFTrigger = true;
        Debug.Log("트리거 실행");
        if (_IMFTrigger)
        {
            Debug.Log("오브젝트 활성화");
            foreach(GameObject Car in VertCars)
            {
                Car.SetActive(true);
            }    
        }
    }
}
