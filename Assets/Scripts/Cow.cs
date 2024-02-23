using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cow : MonoBehaviour, IMovable
{
    public bool hasMilk;
    public GameObject UiObject;

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

        UiObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        new CowMove();
        new CowEat();
        new CowEat();

        UiObject.SetActive(true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        UiObject.SetActive(false);
    }
}
