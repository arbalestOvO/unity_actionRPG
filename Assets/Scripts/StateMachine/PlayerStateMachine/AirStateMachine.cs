using KevinCastejon.HierarchicalFiniteStateMachine;
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
    public class JumpState : AbstractState
    {
        public override void OnEnter()
        {
        }
        public override void OnUpdate()
        {
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
        public override void OnEnter()
        {
        }
        public override void OnUpdate()
        {
        }
        public override void OnFixedUpdate()
        {
        }
        public override void OnExit()
        {
        }
    }
}
