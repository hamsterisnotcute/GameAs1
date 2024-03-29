using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turtle : MonoBehaviour
{
    public bool canSwim;
    public GameObject UiObject;

    // Start is called before the first frame update

    public abstract class Turtlee
    {
        public virtual string Act()
        {
            return "wowowoo";
        }
    }

    public class Move : Turtlee
    {
        public override string Act()
        {
            return " is moving slowly...";
        }       
    }

    public class Eat : Turtlee
    {
        public override string Act()
        {
            return " is munching on lettuce...";
        }      
    }

    public class HideInShell : Turtlee
    {
        public override string Act()
        {
            return " is hiding in its shell.";
        }        
    }

    void Start()
    {
        Move move = new Move();
        Eat eat = new Eat();
        HideInShell hideInShell = new HideInShell();

        Turtlee[] turtle = { move, eat, hideInShell };
        for (int i = 0; i < turtle.Length; i++)
            Debug.Log("Turtle" + turtle[i].Act());

        UiObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            new Move();
        

        
            new Eat();
        

        
            new HideInShell();

            UiObject.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        UiObject.SetActive(false);
    }
}