using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Animal
{
    // Start is called before the first frame update
    void Start()
    {
          public bool hasMilk;

    // Override common behaviors
    public override void Move()
    {
        Debug.Log("Cow is walking slowly...");
    }

    public override void Eat()
    {
        Debug.Log("Cow is munching on grass...");
    }

    // Additional behaviors specific to Cow
    public void ProduceMilk()
    {
        Debug.Log("Cow is producing milk.");
    }
    } 
}
