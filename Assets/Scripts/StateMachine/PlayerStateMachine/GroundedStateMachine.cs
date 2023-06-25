using KevinCastejon.HierarchicalFiniteStateMachine;
using Unity.VisualScripting;
using UnityEngine;

public class GroundedStateMachine : AbstractHierarchicalFiniteStateMachine
{
    public enum States
    {
        IDLE,
        MOVE
    }

    public GroundedStateMachine()
    {
        Init(States.IDLE,
            Create<IdleState, States>(States.IDLE, this),
            Create<MoveState, States>(States.MOVE, this)
        );
    }
    public override void OnStateMachineEntry()
    {
    }
    public override void OnStateMachineExit()
    {
    }

    protected override bool OnAnyStateUpdate()
    {
        if (PlayerInfo.Instance.animator.GetFloat("VerticleSpeed") > 0.001f)
        {
            TransitionToState(EXIT);   
        }
        return base.OnAnyStateUpdate();
    }

    public class IdleState : AbstractState
    {
        public override void OnEnter()
        {
        }
        public override void OnUpdate()
        {
            PlayerInfo.Instance.UpdateAnimatorParameters();
            if (PlayerInfo.Instance.PlayerSpeed > 0.001f)
            {
                TransitionToState(States.MOVE);
            }
        }
        public override void OnFixedUpdate()
        {
        }
        public override void OnExit()
        {
        }
    }
    public class MoveState : AbstractState
    {
        public override void OnEnter()
        {
        }
        public override void OnUpdate()
        {
            PlayerInfo.Instance.UpdateAnimatorParameters();
            if (PlayerInfo.Instance.PlayerSpeed <= 0.001f)
            {
                TransitionToState(States.IDLE);
            }
        }
        public override void OnFixedUpdate()
        {
        }
        public override void OnExit()
        {
        }
    }
}
