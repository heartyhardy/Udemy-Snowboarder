using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleTorque : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1.0f;
    Rigidbody2D rb2d = null;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            rb2d.AddTorque(torqueAmount);
        }
        else if(Input.GetKey(KeyCode.D)){
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
