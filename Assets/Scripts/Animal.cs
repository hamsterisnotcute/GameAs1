using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    // Common attributes
    public string animalName;
    public int age;
    public float health;

    // Abstract methods
    public abstract void Move();
    public abstract void Eat();

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

    }
}