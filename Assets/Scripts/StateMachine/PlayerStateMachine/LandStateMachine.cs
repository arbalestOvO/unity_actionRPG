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
    protected override bool OnAnyStateUpdate()
    {
        if (PlayerInfo.Instance.animator.GetBool("isLandEnd"))
        {
            TransitionToState(EXIT);   
        }
        return base.OnAnyStateUpdate();
    }
    public class IdleState : AbstractState
    {
        public override void OnEnter()
        {
            PlayerInfo.Instance.animator.SetBool("isLandEnd", true);
        }
        public override void OnUpdate()
        {
            PlayerInfo.Instance.UpdateAnimatorParameters();
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
            PlayerInfo.Instance.UpdateAnimatorParameters();
            var stateInfo = PlayerInfo.Instance.animator.GetCurrentAnimatorStateInfo(0);
            if (stateInfo.normalizedTime >= 0.98f)
            {
                PlayerInfo.Instance.animator.SetBool("isLandEnd", true);
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
