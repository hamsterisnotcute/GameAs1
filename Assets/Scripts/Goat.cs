using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goat : MonoBehaviour
{
    public bool hasHorns;

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
    }
}
