using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padle : MonoBehaviour

    
{
    Rigidbody2D RB;
    float playerInput;
    public float speed; 

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();


    }

    private void FixedUpdate()
    {
        RB.velocity = new Vector2(playerInput * speed,10);
        playerInput = Input.GetAxis("Horizontal");


    }
}
