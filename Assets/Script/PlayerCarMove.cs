using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCarMove : MonoBehaviour
{
    public TextMeshProUGUI speedText;
    public int maxSpeed = 15;
    public int speed = 600;
    private float currentSpeed;
    MinusManager _engine;
    AiNavScript ainav;
    public enum Axel
    {
        Front,
        Rear
    }
    [Serializable]
    public struct Wheel
    {
        public GameObject wheelModel;
        public WheelCollider wheelCollider;
        public Axel axel;
    }
    public int maxAccel = 30;

    public float turnSense = 1.0f;
    public float maxSteerAngle = 30.0f;

    public Vector3 _centerOfMass;

    public List<Wheel> wheels;

    float moveInput;
    float steerInput;

    private Rigidbody carRb;

    private void Awake()
    {
        carRb = GetComponent<Rigidbody>();
        carRb.centerOfMass = _centerOfMass;
        _engine = FindAnyObjectByType<MinusManager>();
        ainav = FindAnyObjectByType<AiNavScript>();
    }
    private void Start()
    {
        if (_engine.engine[0])
        {
            speed = 400;
            maxSpeed = 25;
            maxAccel = 35;
        }
        else if (_engine.engine[1])
        {
            speed = 600;
            maxSpeed = 30;
            maxAccel = 40;
        }
        else
        {
            speed = 300;
            maxSpeed = 20;
            maxAccel = 30;
        }
    }

    private void Update()
    {
        GetInput();
        AnimateWheels();
        Displayspeed();
        wheelmass();
    }

    private void LateUpdate()
    {
        Move();
        Steer();
    }

    void GetInput()
    {
        moveInput = Input.GetAxis("Vertical");
        steerInput = Input.GetAxis("Horizontal");
    }

    void wheelmass()
    {
        foreach (var wheel in wheels)
        {
            if (currentSpeed <= 20)
                wheel.wheelCollider.mass = 20;
            else if (currentSpeed >= 60)
                wheel.wheelCollider.mass = 80;
        }
    }

    void Move()
    {
        foreach(var wheel in wheels)
        {
            wheel.wheelCollider.motorTorque = moveInput * speed * maxAccel * Time.deltaTime;
        }
        // 최대 속도 제한
        if (carRb.velocity.magnitude > maxSpeed)
        {
            carRb.velocity = carRb.velocity.normalized * maxSpeed;
        }
    }
    void Steer()
    {
        foreach(var wheel in wheels)
        {
            if(wheel.axel==Axel.Front)
            {
                var _steerAngle = steerInput * turnSense * maxSteerAngle;
                wheel.wheelCollider.steerAngle = Mathf.Lerp(wheel.wheelCollider.steerAngle, _steerAngle, 0.4f);
            }
        }
    }
    void AnimateWheels()
    {
        foreach(var wheel in wheels)
        {

            Quaternion rot;
            Vector3 pos;
            wheel.wheelCollider.GetWorldPose(out pos,out rot);
            wheel.wheelModel.transform.position = pos;
            wheel.wheelModel.transform.rotation = rot;
        }
    }
    void Displayspeed()
    {
        currentSpeed = carRb.velocity.magnitude*3.6f;
        speedText.text = "Speed: " + currentSpeed.ToString("F0") + " km/h"; // 소수점 이하 자리 없이 속도를 표시
    }
}
