using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public KeyColor keyColorRequired; //this is declaring the color of the key thats needed per door

    public Transform doorFinalPosition; // this is the location of the doors final position in level

    public bool isDoorLocked = true; //this bool checks if the door is locked

    public bool hasBeenOpened = false; // this bool checks if the door has been opened

    public AudioSource doorIsOpened; //this is the audio source that plays during a function



    private void Start()
    {
        if (keyColorRequired == KeyColor.Green) //check if the keycolor enumerate is green
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green; //if it is then change this game object to green by changing its material component
        }
        else if (keyColorRequired == KeyColor.Blue) //if it is not green then check if the enumerate is blue
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue; //if it is then change this game object to blue by changing its material component
        }
        else if (keyColorRequired == KeyColor.Red) //if the enumerate is not green or blue then check it if is red
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red; //if it is then change this game object to red
        }
    }

    public void OpenDoor() //the name of the fucntion and what is inside of it
    {
        if(hasBeenOpened == false) //if the bool hasBeenOpened is false
        {
            this.transform.position = doorFinalPosition.position; //change this objects position to the before established final loction
            hasBeenOpened = true; //change the hasBeenOpened bool to true
        }

        else if(hasBeenOpened == true) //if the hasBeenOpened bool is true
        {
            doorIsOpened.Play(); //then play this audio source
        }
       
    }
}
