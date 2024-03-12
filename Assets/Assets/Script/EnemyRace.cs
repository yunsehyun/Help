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
            Debug.Log("½Â¸®");
        }
        else if(other.CompareTag("Enemy"))
        {
            Debug.Log("ÆÐ¹è");
        }
    }
}
 