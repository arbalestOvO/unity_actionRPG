using KevinCastejon.HierarchicalFiniteStateMachine;
using UnityEngine;

public class AirStateMachine : AbstractHierarchicalFiniteStateMachine
{
    public enum States
    {
        JUMP,
        FALL
    }
    public AirStateMachine()
    {
        Init(States.JUMP,
            Create<JumpState, States>(States.JUMP, this),
            Create<FallState, States>(States.FALL, this)
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
        if (PlayerInfo.Instance.animator.GetFloat("VerticleRigidforce") <= 0.001f)
        {
            TransitionToState(EXIT);   
        }
        return base.OnAnyStateUpdate();
    }
    public class JumpState : AbstractState
    {
        public override void OnEnter()
        {
        }
        public override void OnUpdate()
        {
            PlayerInfo.Instance.UpdateAnimatorParameters();
            if (PlayerInfo.Instance.animator.GetFloat("VerticleSpeed") <= 0.001f)
            {
                TransitionToState(States.FALL);
            }
        }
        public override void OnFixedUpdate()
        {
        }
        public override void OnExit()
        {
        }
    }
    public class FallState : AbstractState
    {
        private float FallingTime;
        public override void OnEnter()
        {
            FallingTime = 0f;
        }
        public override void OnUpdate()
        {
            PlayerInfo.Instance.UpdateAnimatorParameters();
            FallingTime += Time.deltaTime;
            PlayerInfo.Instance.animator.SetFloat("FallingTime", FallingTime);
        }
        public override void OnFixedUpdate()
        {
        }
        public override void OnExit()
        {
        }
    }
}
