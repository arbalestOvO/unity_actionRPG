using KevinCastejon.HierarchicalFiniteStateMachine;
public class LandStateMachine : AbstractHierarchicalFiniteStateMachine
{
    public enum States
    {
        IDLE,
        Land
    }
    public LandStateMachine()
    {
        Init(States.IDLE,
            Create<IdleState, States>(States.IDLE, this),
            Create<LandState, States>(States.Land, this)
        );
    }
    public override void OnStateMachineEntry()
    {
    }
    public override void OnStateMachineExit()
    {
    }
    public class IdleState : AbstractState
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
    public class LandState : AbstractState
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
