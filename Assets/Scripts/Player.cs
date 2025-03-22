using System.Collections;
using System.Collections.Generic;
using Unity.Hierarchy;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool hasGreenKey = false; //creates a public bool that states if something is true or false, in this instance is asks if the player has the green key or not
    public bool hasBlueKey = false; //another bool asking if the player has the blue key or not (the player being what this script is placed on)
    public bool hasRedKey = false; // another bool asking if the player has the red key or not

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) //if the E key is pressed
        {
            RaycastHit hit; // it creates a raycast
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit)) //if the the raycast that is casted from the camera hits/sees something
            {
                if (hit.collider.tag == "Door") //if the something in scene is tagged with the "Door" tag
                {
                    LockedDoor door = hit.collider.gameObject.GetComponent<LockedDoor>(); //check if it has the door script

                    if (door.keyColorRequired == KeyColor.Blue && hasBlueKey == true) //if the key color required that is declared in the referenced door script
                     // is blue AND the hasBluekey bool is true
                    {
                        door.OpenDoor(); //then play the opendoor function that is inside the referenced locked door script

                    }
                    else if(door.keyColorRequired == KeyColor.Green && hasGreenKey == true) // if the referenced keycolor is not blue and they do not have the blue key,
                        // then check if the key color required is green and if the hasGreenKey is bool is true
                    {
                        door.OpenDoor(); //if both are true then play the openDoor function
                    }
                    else if(door.keyColorRequired == KeyColor.Red && hasRedKey == true)// if it is neither of the above options then check is the key color required is red
                        //and if the hasRedKey bool is true
                    {
                        door.OpenDoor(); //if both are true then play the openDoor  function
                    }



                }
            }
        }
    }
}
