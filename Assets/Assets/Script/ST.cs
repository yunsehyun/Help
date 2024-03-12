using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class ST : MonoBehaviour
{
    public GameObject _store;

    private void Awake()
    {
        if(Random.Range(0f,1f)<0.5f)
        {
            this.gameObject.SetActive(false);
        }
    }
     
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("트리거 발동");
        if(other.CompareTag("PC"))
        {
            Time.timeScale = 0;
            _store.SetActive(true);
        }
    }
}
