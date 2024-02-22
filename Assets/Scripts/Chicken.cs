using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    public bool hasFeathers;

    // Start is called before the first frame update
    
    public abstract class Chickennn
    {
        public virtual string Act()
        {
            return "jisung";
        }
    }
    public class Move : Chickennn
    {
        public override string Act()
        {
            return " is pecking around...";
        }
        
    }

    public class Eat : Chickennn
    {
        public override string Act()
        {
            return " is eating seeds...";
        }
       
    }

    public class LayEgg : Chickennn
    {
        public override string Act()
        {
            return " laid an egg!";
        }      
    }

    void Start()
    {
        Move move = new Move();
        Eat eat = new Eat();
        LayEgg layEgg = new LayEgg();

        Chickennn[] chicken = { move, eat, layEgg };
        for (int i = 0; i < chicken.Length; i++)
            Debug.Log("Chicken" + chicken[i].Act());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            new Move();
        }

        if (collision.gameObject.tag == "Player")
        {
            new Eat();
        }

        if (collision.gameObject.tag == "Player")
        {
            new LayEgg();
        }
    }
}
