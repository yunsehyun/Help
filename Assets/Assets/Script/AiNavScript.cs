using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiNavScript : MonoBehaviour
{
    public Transform _here;
    private NavMeshAgent _agent;
    public List<Wheel> wheels;
    public GameObject _start;
    public Transform target;
    private float distance;
    public List<int> _accel;
    public List<int> _speed;

    [Serializable]
    public struct Wheel
    {
        public GameObject wheelModel;
    }
    
    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        Invoke("Move", 5.5f);
    }

    private void Move()
    {
        _agent.destination = _here.position;
    }

    private void FixedUpdate()
    {
        distance = Vector3.Distance(transform.position, target.position);
        Debug.Log(distance.ToString());
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
