using NUnit.Framework;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class ReActivate : MonoBehaviour
{
    public List<Target> targets = new List<Target>();//create list of objects, called targets, that contain the target script

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targets = FindObjectsByType<Target>(FindObjectsSortMode.None).ToList();//adds objects with the target script into the list when game is started
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.R)) //if the R key is pressed
        {
            foreach (Target t in targets) //then for each target that is in the target list run this loop of
            {
                if (t.gameObject.activeSelf == false) //checking if the gameobject is active in scene, if it is not
                {
                    t.gameObject.SetActive(true); //then make the object active in scene again
                }
            }
        }
     
    }
}
