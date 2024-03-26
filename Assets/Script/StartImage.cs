using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartImage : MonoBehaviour
{
    public List<Sprite> _sprite = new List<Sprite>();
    Image _image;
    GameStart _gamestart;

    private void Awake()
    {
        _gamestart=FindAnyObjectByType<GameStart>();
        _image= GetComponent<Image>();
    }

    void FixedUpdate()
    {
        _image.sprite = _sprite[(int)_gamestart.cnt];
    }


}
