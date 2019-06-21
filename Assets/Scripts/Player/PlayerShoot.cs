//------------------------------------------------------------------------------
// Author: Bailee Vaughan
// Title: PlayerShoot
// Date: 27th May
// Details: Instantiates a sprite onto the shot origin position
// URL: 
//------------------------------------------------------------------------------

using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shotOrigin;
   
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            Debug.Log("Shot");
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, shotOrigin.position, shotOrigin.rotation);        
    }
}
