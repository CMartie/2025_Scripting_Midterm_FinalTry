using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public KeyColor keyColorRequired; //this is declaring the color of the key thats needed per door

    public Transform doorFinalPosition; // this is the location of the doors final position in level

    public bool isDoorLocked = true; //this bool checks if the door is locked

    public bool hasBeenOpened = false; // this bool checks if the door has been opened

    public AudioSource doorIsOpened;



    private void Start()
    {
        if (keyColorRequired == KeyColor.Green)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else if (keyColorRequired == KeyColor.Blue)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else if (keyColorRequired == KeyColor.Red)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    public void OpenDoor()
    {
        if(hasBeenOpened == false)
        {
            this.transform.position = doorFinalPosition.position;
        }

        if(hasBeenOpened == true)
        {
            doorIsOpened.Play();
        }
       
    }
}
