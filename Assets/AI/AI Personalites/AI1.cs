using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class AI1 : AIBaseController
{

    AIBaseController ChaseRef;
    IState AttackState { get; set; }
    IState BaseState { get; set; }

    IState ChaseState { get; set; }

    IState FleeState { get; set; }

    IState PatrolState { get; set; }


    public List<Transform> RouteList;

    // Start is called before the first frame update
    void Start()
    {
        AIStateMachine = new StateMachine();

        FleeState = new FleeState(this);

        PatrolState = new PatrolState(this, RouteList);

        AttackState = new AttackState(this);


        ChaseState = new ChaseState(this);

        BaseState = new IdleState();

        //CreateTransition(ChaseState, AttackState, When);
        AIStateMachine.SetState(PatrolState);

        ///
        /// Next is the flee state. have a list of transforms that the ai pawn can look at once it reaches a threshold of health 
        /// Flee State is done, just need to add a condition 
        /// Next is the patrol state, have a list of transforms the ai pawn could move to until it spots the player
        ///

    }

    private void Update()
    {

        AIStateMachine.Tick();



    }


    // Start is called before the first frame update
    bool When() // Cannot add parameters in bools, for references 
    {

        return true;
        // Temp fix
    }

}