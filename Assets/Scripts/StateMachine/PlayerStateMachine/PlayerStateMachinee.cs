using KevinCastejon.HierarchicalFiniteStateMachine;
using UnityEngine;

public class PlayerStateMachinee : AbstractHierarchicalFiniteStateMachine
{
    public enum States
    {
        GROUNDED,
        AIR,
        LAND
    }
    public PlayerStateMachinee()
    {
        Init(States.GROUNDED,
            Create<GroundedStateMachine, States>(States.GROUNDED, this),
            Create<AirStateMachine, States>(States.AIR, this),
            Create<LandStateMachine, States>(States.LAND, this)
        );
    }
    public override void OnExitFromSubStateMachine(AbstractHierarchicalFiniteStateMachine subStateMachine)
    {
        Debug.Log(subStateMachine.Name);
        if (subStateMachine.Name == "AIR")
        {
            TransitionToState(States.LAND);
        }else if (subStateMachine.Name == "GROUNDED")
        {
            TransitionToState(States.AIR);
        }
        else
        {
            TransitionToState(States.GROUNDED);
        }
    }
    public override void OnStateMachineEntry()
    {
    }
    public override void OnStateMachineExit()
    {
    }
}
