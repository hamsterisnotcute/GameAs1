using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goat : MonoBehaviour
{
    public bool hasHorns;
    public GameObject UiObject;

    public abstract class GOOOAT
    {
        public virtual string Act()
        {
            return "baebaebabebaeeekhyunnnn";
        }
        
    }

    public class Move : GOOOAT
    {
        public override string Act()
        {
            return " is trotting around...";
        }
    }

    public class Eat: GOOOAT
    {
        public override string Act()
        {
            return " is grazing on grass...";
        }
    }

    public class Charge : GOOOAT
    {
        public override string Act()
        {
            return " is charging!";
        }
    }

    void Start()
    {
        Move move = new Move();
        Eat eat = new Eat();
        Charge charge = new Charge();

        GOOOAT[] goat = { move, eat, charge };
        for (int i = 0; i < goat.Length; i++)
            Debug.Log("Goat" + goat[i].Act());

        UiObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            new Move();
        

        
            new Eat();
        

        
            new Charge();

            UiObject.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        UiObject.SetActive(false);
    }
}
