using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    [SerializeField] Rigidbody2D backWheel,frontWheel;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        backWheel = GameObject.Find("BackWheel").GetComponent<Rigidbody2D>();
        frontWheel = GameObject.Find("FrontWheel").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if  (Input.GetKey(KeyCode.W))
        {
            backWheel.AddTorque(-1*speed*Time.fixedDeltaTime);
            frontWheel.AddTorque(-1 * speed * Time.fixedDeltaTime) ;          
        }
        if (Input.GetKey(KeyCode.S))
        {
            backWheel.AddTorque(1 * speed * Time.fixedDeltaTime);
            frontWheel.AddTorque(1 * speed * Time.fixedDeltaTime);
        }
    }
}
