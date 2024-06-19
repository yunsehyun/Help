using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiNavScript : MonoBehaviour
{
    public List<Transform> _here= new List<Transform>();
    public NavMeshAgent _agent;
    public List<Wheel> wheels;
    public GameObject _start;
    public Transform target;
    public float distance;
    public float distance2;
    public List<int> _accel;
    public List<int> _speed;
    MinusManager minusmanager;

    [Serializable]
    public struct Wheel
    {
        public GameObject wheelModel;
    }
    
    private void Awake()
    {
        minusmanager = FindAnyObjectByType<MinusManager>();
        _agent = GetComponent<NavMeshAgent>();
        Invoke("Move", 5.5f);
    }

    private void Move()
    {
        _agent.destination = _here[0].position;
    }

    private void OnTriggerEnter(Collider other)
    {
        _agent.acceleration = _accel[0];
    }
 
    private void FixedUpdate()
    {
        distance = Vector3.Distance(transform.position, target.position);
        distance2 = Vector3.Distance(transform.position, _here[0].position);
        if (distance2 < 20) _agent.destination = _here[1].position;
        //Debug.Log(distance.ToString());
        if (distance >= 76)
        {
            Dis();
        }
        else if(distance<=20)
        {
            mir();
        }
        else
        {
            _agent.acceleration = _accel[0];
            _agent.speed = _speed[0];
        }
            AnimateWheels();
    }
    
    void Dis()
    {
        _agent.acceleration = _accel[1];
        _agent.speed = _speed[1];
    }

    void mir()
    {
        _agent.acceleration = _accel[2];
        _agent.speed = _speed[2];
    }

    void AnimateWheels()
    {
        foreach (var wheel in wheels)
        {

            wheel.wheelModel.transform.Rotate(Vector3.right);
        }
    }
}
