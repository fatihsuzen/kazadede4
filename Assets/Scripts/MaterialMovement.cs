using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MaterialMovement : MonoBehaviour
{
    float y ;
    public static float hız = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        y = transform.position.y;
      
    }

    // Update is called once per frame
    void Update()
    {

        Movement();


    }
    void Movement()
    {
        gameObject.transform.position = new Vector2(transform.position.x, y);
        y += hız;
    }
   
    
}
