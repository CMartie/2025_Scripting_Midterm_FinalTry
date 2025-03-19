using NUnit.Framework;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class ReActivate : MonoBehaviour
{
    public List<Target> targets = new List<Target>();

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targets = FindObjectsByType<Target>(FindObjectsSortMode.None).ToList();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.R))
        {
            foreach (Target t in targets)
            {
                if (t.gameObject.activeSelf == false)
                {
                    t.gameObject.SetActive(true);
                }
            }
        }
     
    }
}
