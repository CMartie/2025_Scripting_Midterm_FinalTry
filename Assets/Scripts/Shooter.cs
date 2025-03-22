using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab; //declares a public prefab that is used as the actual object tagged as bullet
    public float bulletForce; //a float that declares the force that the prefab is pushed in a certain direction, because it is public you change in the scripts inspector
    public Transform bulletSpawnPosition;//the position the bulletprefab is set to spawn in in scene at start

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //if you press the right mouse button 
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition.position, bulletSpawnPosition.rotation);//spawn the declared bulletprefab model
            //at the starting position

            

            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletForce); //add the force established in the public float to the prefab by influencing
            //the objects transform by accessing its rigid body

            Destroy(bullet, 3f);// then destroy the bulletprefab in 3 seconds after spawning
        }
    }
}
