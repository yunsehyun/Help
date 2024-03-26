using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCarMove : MonoBehaviour
{
    public TextMeshProUGUI speedText;
    public int maxSpeed = 15;
    public int speed = 600;
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
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        GetInput();
        AnimateWheels();
        Displayspeed();
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

    void Move()
    {
        foreach(var wheel in wheels)
        {
            wheel.wheelCollider.motorTorque = moveInput * speed * maxAccel * Time.deltaTime;
        }
        // �ִ� �ӵ� ����
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
        float currentSpeed = carRb.velocity.magnitude*3.6f;
        speedText.text = "Speed: " + currentSpeed.ToString("F0") + " km/h"; // �Ҽ��� ���� �ڸ� ���� �ӵ��� ǥ��
    }
}
