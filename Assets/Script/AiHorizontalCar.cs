using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiHorizontalCar : MonoBehaviour
{
    public float speed = 0.2f;
    public int rotate = -90;
    private void Update()
    {
        Move();
        if ((transform.position.x <= -73)||(transform.position.x)>=53)
        {
            speed = -speed;
            transform.Rotate(0, rotate, 0);
        }
    }

    void Move()
    {
        transform.Translate(0, 0, speed);
    }
}
