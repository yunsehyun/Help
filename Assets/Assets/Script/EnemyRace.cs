using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRace : MonoBehaviour
{
    public List<GameObject> Cars;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PC"))
        {
            Debug.Log("�¸�");
        }
        else if(other.CompareTag("Enemy"))
        {
            Debug.Log("�й�");
        }
    }
}
 