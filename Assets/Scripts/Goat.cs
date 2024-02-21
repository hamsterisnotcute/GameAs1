using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goat : Animal
{
    public bool hasHorns;

    public override void Move()
    {
        Debug.Log("Goat is trotting around...");
    }

    public override void Eat()
    {
        Debug.Log("Goat is grazing on grass...");
    }

    public void Charge()
    {
        Debug.Log("Goat is charging!");
    }
}
