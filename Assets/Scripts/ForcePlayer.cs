using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcePlayer : MonoBehaviour {

    public int LifePoints { private set; get; }
    private Zone[] _zones;
    public bool IsTurnPLayer;

    public ForcePlayer()
    {

    }

    public void GainLife(int amount)
    {
        LifePoints += amount;
    }

    public void LoseLife(int amount)
    {
        LifePoints -= amount;
        //Check for Losingcondition
        if (LifePoints <= 0)
            //TODO: Throw Lose Game event
            return;
    }
}
