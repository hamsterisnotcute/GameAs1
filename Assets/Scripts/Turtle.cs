using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : Animal
{
    public bool canSwim;

    // Start is called before the first frame update
    void Start()
    {
    }

    public override void Move()
    {
        Debug.Log("Turtle is moving slowly...");
    }

    public override void Eat()
    {
        Debug.Log("Turtle is munching on lettuce...");
    }

    public void HideInShell()
    {
        Debug.Log("Turtle is hiding in its shell.");
    }      
}