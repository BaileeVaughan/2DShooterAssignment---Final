//------------------------------------------------------------------------------
// Author: Bailee Vaughan
// Title: PlayerController
// Date: 28th May
// Details: Locks the players rotation to the mouse, moves and shoots via mouse buttons
// URL: 
//------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] //for movement
public class PlayerController : MonoBehaviour
{
    public float speed;
    public float dist;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        dist = Vector3.Distance(Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.position);
    }
    void LateUpdate()
    {
        float inputV = Input.GetAxis("Fire2");
        if (inputV >= 0)
        {
            Vector2 moveInput = new Vector2(0, inputV);

            moveInput = transform.TransformDirection(moveInput);

            moveVelocity = moveInput * speed;
        }
        FaceMouse();
    }

    private void FixedUpdate()
    {
        if (dist > 10.008f)
        {
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        }
    }

    void FaceMouse()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - (Vector2)transform.position;
        transform.up = direction;
    }
}

