using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerControlller : Controller
{
    #region Floats and Keycodes 
    // This will be a list of each key that will be 
    // Pretty much saying "if physical key tied to this movement is pressed, move"
    public KeyCode moveForwardKey;
    public KeyCode moveBackwardKey;
    public KeyCode moveClockWise;
    public KeyCode moveCounterClockWiseKey;
    public KeyCode shootKey;
    public KeyCode switchKey;
    public float speed = 10.0f;
    public float rotateSpeed = 180f;
    public GameObject Newplayer;

    #endregion  
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();

        // If we have game manager 
        if (GameManager.instance.players != null)
        {
            // and if it can track players 
            if (GameManager.instance.players != null)
            {
                // Register it to the GameManager
                GameManager.instance.players.Add(this);
            }
        }
    }

    // This will destory the player once it needs to r
    public void OnDestroy()
    {
        // If we have the game mananger 
        if (GameManager.instance.players != null)
        {
            // and if the game manager can track players
            if (GameManager.instance.players != null)
            {
                // Register the player to the GameManager
                // We added this so once a tank or player is removed
                // it no longer takes up memory
            }   GameManager.instance.players.Remove(this);
        }
    }




    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        ProcessInputs();
        var transAmount = speed * Time.deltaTime;
        var rotateAmount = rotateSpeed * Time.deltaTime;
        // variables for movement speed 
        // and rotation speed
    }

    #region Process Inputs
    public void ProcessInputs()
    {
        if (Input.GetKey(moveForwardKey))
        {
            pawn.MoveForward();
            // Like I said, tying Keys to inputs
        }
        if (Input.GetKey(moveBackwardKey))
        {
            pawn.MoveBackward();
        }
        if (Input.GetKey(moveClockWise))
        {
            pawn.RotateClockWise();
        }

        if (Input.GetKey(moveCounterClockWiseKey))
        {
            pawn.RotateCounterClockWise();
        }

        if (Input.GetKeyDown(shootKey)) 
        {
            pawn.Shoot();        
        }

        if (Input.GetKeyDown(switchKey)) 
        {
            pawn.Switch();
        }

        // Comment from the previous build  
        // 
        //
        // Might implement raycast underneath the tank at all times, when it hasn't touched anything in 3 seconds,
        // add a ui option where it says "press r to flip" when they press that button, and the raycast isn't hitting 
        // anything, just move them up on the Y axis and rotate them to face forward, could change transform.poistion for the Y axis,
        // and transform.rotation to face the player forward
    }

}
#endregion