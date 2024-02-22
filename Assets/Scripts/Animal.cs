using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour {
    // Common attributes
    public string animalName;
    public int age;
    public float health;

    // Abstract methods
    public abstract void Move();
    public abstract void Eat();

    // Interaction method
    public virtual void Interact() {
        // Default interaction behavior for all animals
        Debug.Log("Interacting with the animal");
    }

    // Inspect method
    public virtual void Inspect() {
        // Default inspection behavior for all animals
        Debug.Log("Inspecting the animal");
    }

    // Call this method when interaction is triggered
    public void OnInteraction() {
        Interact();
    }

    // Call this method when inspection is triggered
    public void OnInspection() {
        Inspect();
    }
}