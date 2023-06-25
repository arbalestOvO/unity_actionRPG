using KevinCastejon.HierarchicalFiniteStateMachine;
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
    public class IdleState : AbstractState
    {
        public override void OnEnter()
        {
        }
        public override void OnUpdate()
        {
            PlayerInfo.Instance.animator.SetFloat("", PlayerInfo.Instance.PlayerSpeed);
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
        }
        public override void OnFixedUpdate()
        {
        }
        public override void OnExit()
        {
        }
    }
}
