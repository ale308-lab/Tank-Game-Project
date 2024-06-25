using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // The pawn that this controller is controlling. 
    //AKA main pawn playercontroller will be using
    public Pawn pawn;
    public virtual void Start()
        // As of 6/11/2024 not having either of these be virtual voids 
        // caused a stack overflow.
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }
}
