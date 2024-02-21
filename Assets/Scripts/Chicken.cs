using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    public bool hasFeathers;

    public override void Move()
    {
        Debug.Log("Chicken is pecking around...");
    }

    public override void Eat()
    {
        Debug.Log("Chicken is eating seeds...");
    }

    public void LayEgg()
    {
        Debug.Log("Chicken laid an egg!");
    }
    }
}
