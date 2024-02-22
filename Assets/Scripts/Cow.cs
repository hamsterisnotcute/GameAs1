using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : MonoBehaviour, IMovable
{
    public bool hasMilk;

    // Start is called before the first frame update

    public abstract class COWWW
    {
        public virtual string Act()
        {
            return "chanyeool";
        }
    }

    public class CowMove : COWWW
    {
        public override string Act()
        {
            return " is walking slowly...";
        }
    }

    public class CowEat : COWWW
    {
        public override string Act()
        {
            return " is munching on grass...";
        }
        
    }

    public class ProduceMilk : COWWW
    {
        public override string Act()
        {
            return " is producing milk.";
        }
        
    }

    public void Move(Vector3 destination)
    {
        transform.position = destination;
    }

    void Start()
    {
        CowMove cowMove = new CowMove();
        CowEat cowEat = new CowEat();
        ProduceMilk produceMilk = new ProduceMilk();

        COWWW[] cow = { cowMove, cowEat, produceMilk };
        for (int i = 0; i < cow.Length; i++)
            Debug.Log("Cow" + cow[i].Act());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            new CowEat();
        

        
        
            new CowMove();
        

        
            new ProduceMilk();

            

        }
    }
}
