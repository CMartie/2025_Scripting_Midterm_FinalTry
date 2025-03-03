using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool hasGreenKey = false;
    public bool hasBlueKey = false;
    public bool hasRedKey = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
            {
                if (hit.collider.tag == "Door")
                {
                    LockedDoor door = hit.collider.gameObject.GetComponent<LockedDoor>();

                    if (door.keyColorRequired == KeyColor.Blue && hasBlueKey == true)
                    {
                        door.OpenDoor();

                    }
                    else if(door.keyColorRequired == KeyColor.Green && hasGreenKey == true)
                    {
                        door.OpenDoor();
                    }
                    else if(door.keyColorRequired == KeyColor.Red && hasRedKey == true)
                    {
                        door.OpenDoor();
                    }



                }
            }
        }
    }
}
