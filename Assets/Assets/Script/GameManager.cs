using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject _Store;
    public GameObject _Items;
    public GameObject _Stop;
    private void Awake()
    {
        _Store.SetActive(false);
        _Items.SetActive(false);
        _Stop.SetActive(false);
    }
}
