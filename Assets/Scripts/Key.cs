using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyColor // this creates the key color choices before their uses in the public class
{
    Green,
    Blue,
    Red
}

public class Key : MonoBehaviour
{
    public KeyColor keyColor; // gives name/declares key color

    private void Start()
    {
        if(keyColor == KeyColor.Green) //this checks the color of keyColor, specifically if it is green
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green; // this this changes the game object with this script to the color  green by changing things it its mesh renderer
        }
        else if (keyColor == KeyColor.Blue) // like 2 lines above, its checking the objects color to see if it is NOT green but instead blue
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue; //if assigned blue then it changes the game object to blue
        }
        else if (keyColor == KeyColor.Red) // same as above but checks for red
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red; // turns object red
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") //if something runs into this collider it checks for a player tag
        {
            Player player = other.GetComponent<Player>(); //gets componants from the player script

            if (keyColor == KeyColor.Green)
            {
                if (player.hasGreenKey == false)
                {
                    player.hasGreenKey = true;
                    Destroy(gameObject);
                }
            }
            else if (keyColor == KeyColor.Blue)
            {
                if (player.hasBlueKey == false)
                {
                    player.hasBlueKey = true;
                    Destroy(gameObject);
                }
            }
            else if (keyColor == KeyColor.Red)
            {
                if (player.hasRedKey == false)
                {
                    player.hasRedKey = true;
                    Destroy(gameObject);
                }
            }
            
        }
    }
}
