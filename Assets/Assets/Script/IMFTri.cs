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
        Debug.Log("Ʈ���� ����");
        if (_IMFTrigger)
        {
            Debug.Log("������Ʈ Ȱ��ȭ");
            foreach(GameObject Car in VertCars)
            {
                Car.SetActive(true);
            }    
        }
    }
}
