using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public enum TargetType
{
    Destroyable, //declaring and establishing the types of targets designated  in scene- this one is the destructable target
    Movable, //movable target
    DestroyableWithSound //destroyable target that also plays a sound
}

public class Target : MonoBehaviour
{ 
    public AudioSource targetSound; //the audio source of the soundd that plays when destroying the DestroyableWithSound target
    public TargetType targetType; //declaring the enumerate that was placed above the public class sector
    private Vector3 startingPosition; //the x,y,z location in scene that the target starts
    public float maxMovingTargetRange = 3f; //max range from starting position that Movable target can move
    public float minMovingTargetRange = 1f; //minimum range from starting position that movable target can move in

    void Start()
    {
        startingPosition = transform.position; //starting position is the position they are posed in in scene

        if (targetType == TargetType.Destroyable) //if the target is the destroyable enumerate 
        {
            this.GetComponent<MeshRenderer>().material.color = Color.magenta; //then change the color of target to magenta by changing the material component
        }
        else if (targetType == TargetType.Movable) // if the target is not the destroyable enumerate and is instead the movable enumerate
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red; // then change the color of the targe to red by changing the material component
        }
        else if (targetType == TargetType.DestroyableWithSound) // if the target is neither the movable or destoyable enumerate it is the DestroyableWithSound enumerate
        {
            this.GetComponent<MeshRenderer>().material.color = Color.yellow; //if it is the destroyable with sound enumerate that change it's color to yellow by changing the material component
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet") //if a gameobject collides with targets and is tagged as "Bullet"
        {
            
            
            if(targetType == TargetType.Destroyable) //then check if the target that was collided into is the destroyable enumerate
            {
                gameObject.SetActive(false); //if it is then set this target inactive, hiding it in scene

            }
            else if(targetType == TargetType.Movable) // if it is not, check if the target is the movable enumerate
            {
                float randomY = Random.Range(minMovingTargetRange, maxMovingTargetRange);// if it is then this declared float is a random range between the above declared public floats
                // minMovingRange and maxMovingRange in the Y range

                float randomZ = Random.Range(minMovingTargetRange, maxMovingTargetRange); // if it is then this declared float is a random range between the above declared public floats
                //minMovingRange and maxMovingRange in the Z range

                transform.position = startingPosition + new Vector3(0f, randomY, randomZ); //add the targets starting position with a new vector, a new location
                //that is a random location between the y and z coordinates that was established in th above lines
            }
            else if (targetType == TargetType.DestroyableWithSound)// if it is not then check if it is the DestroyableWithSound enumerate
            {
                targetSound.Play(); //if it is then play sound on collision
                gameObject.SetActive(false); // and then set inactive and hide in scene
            }
        }
    }
}