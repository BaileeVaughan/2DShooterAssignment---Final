//------------------------------------------------------------------------------
// Author: Bailee Vaughan
// Title: Bullet
// Date: 27th May
// Details: Basic forward movement of a sprite and damage
// URL: 
//------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 20;
    public Rigidbody2D rb;

    void Start()
    {        
        rb.velocity = transform.up * speed;
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        Enemy enemy = col.GetComponent<Enemy>();        
        if (enemy != null)
        {
            enemy.TakeDamage(20);
            Debug.Log("Hit");
        }
        Destroy(gameObject);
    }
}
