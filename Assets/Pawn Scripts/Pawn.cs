using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    /// <summary>
    /// This pawn will contain information for our movement a
    /// as well as any updates or references for other scripts to inherent
    /// 
    /// </summary>
    /// 



    public float moveSpeed;
    // Variable for the in game movement speed
    public float turnSpeed;
    // Var that will control the turn speed of the player

    // Start is called before the first frame update
    public virtual void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }


    // These abstracts are all the basic functions I will be using for the tank movement 
    // They are stored here so any script requiring them will be able to easily inherent them

    public abstract void MoveForward();

    public abstract void MoveBackward();

    public abstract void RotateClockWise();
    // Left

    public abstract void RotateCounterClockWise();
    // Right

    public abstract void Shoot();
    public abstract void RotateTowards(Vector3 targetPosition);
    // Ability for AI to move towards target AKA player
    public abstract void Switch();
    // Ability to Switch states


}
