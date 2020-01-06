﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;

    private Rigidbody2D body;
    private Vector3 change;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if (change != Vector3.zero)
        {
            MoveCharacter();
        }
    }


    void MoveCharacter()
    {
        body.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
}
