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
            Player player = other.GetComponent<Player>(); //gets componants (player) from the player script

            if (keyColor == KeyColor.Green) //checks if keycolor is green
            {
                if (player.hasGreenKey == false) // if the color is green it checks if the player does NOT have the green key
                {
                    player.hasGreenKey = true; // if the player doesnt have the green key they now have the green key
                    Destroy(gameObject); // and the key is destoyed in the level
                }
            }
            else if (keyColor == KeyColor.Blue) //if the key is NOT green in the above if statement it checks if the key is blue
            {
                if (player.hasBlueKey == false) // if the key is blue and the player does NOT have the blue key
                {
                    player.hasBlueKey = true; // they then have the blue key
                    Destroy(gameObject); // and the blue key is destoyred in the level
                }
            }
            else if (keyColor == KeyColor.Red) // if the above if statements are not true and the key is neither green nor blue it checks if the key  is red
            {
                if (player.hasRedKey == false) // if the key is red it checks if the player does NOT have the red key
                {
                    player.hasRedKey = true; // if the player does not have the red key the player now has the red key
                    Destroy(gameObject); // and the key is destroyed in the level
                }
            }
            
        }
    }
}
