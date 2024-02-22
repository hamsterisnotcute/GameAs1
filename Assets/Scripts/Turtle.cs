using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour
{
    public bool canSwim;

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
    }
}