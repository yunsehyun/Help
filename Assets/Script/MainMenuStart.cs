using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuStart : MonoBehaviour
{
    public string _scene;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(_scene);
    }
}
