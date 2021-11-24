using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleTorque : MonoBehaviour
{
    [SerializeField] SurfaceEffector2D effector2D = null;
    [SerializeField] float torqueAmount = 1.0f;
    [SerializeField] float boostSpeed = 10.0f;
    float baseSpeed = 1f;
    Rigidbody2D rb2d = null;
    void Start()
    {
        effector2D = FindObjectOfType<SurfaceEffector2D>();
        rb2d = GetComponent<Rigidbody2D>();

        baseSpeed = effector2D.speed;
    }

    // Update is called once per frame
    void Update()
    {
        AddTorque();
        Boost();
    }

    void Boost()
    {
        if(Input.GetKey(KeyCode.W)){
            effector2D.speed = boostSpeed;
        }else{
            effector2D.speed = baseSpeed;
        }
    }

    void AddTorque()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
