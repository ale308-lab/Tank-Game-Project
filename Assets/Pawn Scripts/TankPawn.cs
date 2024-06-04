using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPawn : Pawn
{

    public float speed = 10.0f;
    public float rotateSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();

    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
    }

    public override void MoveForward()
    {


    }

    public override void MoveBackward()
    {


    }

    public override void RotateClockWise()
    {


    }

    public override void RotateCounterClockWise()
    {


    }

    public override void RotateTowards(Vector3 targetPosition)
    {


    }

    public override void Shoot()
    {
        throw new System.NotImplementedException();
    }

    public override void Switch()
    {
        throw new System.NotImplementedException();
    }

}
