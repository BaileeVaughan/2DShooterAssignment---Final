//------------------------------------------------------------------------------
// Author: Jacob Nicholls-Smart
// Details: Manager for making Enemies shoot and Move
//------------------------------------------------------------------------------



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float speed;  // refers to the units speed
    public float TargetDistance;   // refers to the distance the unit wants to be from the target before it starts shooting
    public float MinimumDistance;    // Refers to the distance that the unit will begin to retreat from the player if they approach

    private float timeBtwShots;
    public float ShotDelay;

    public GameObject projectile;
    private Transform player;  

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        timeBtwShots = ShotDelay;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) > TargetDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, player.position) < TargetDistance && Vector2.Distance(transform.position, player.position) > MinimumDistance)
        {
            transform.position = this.transform.position;
        }
        else  if (Vector2.Distance(transform.position, player.position) < MinimumDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime); // using - speed to make it essentially step back as if its in fear or retreating
        }

        if(timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = ShotDelay;
        } 
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
