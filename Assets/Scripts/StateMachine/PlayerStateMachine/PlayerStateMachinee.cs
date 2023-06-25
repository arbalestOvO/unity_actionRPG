using KevinCastejon.HierarchicalFiniteStateMachine;
public class PlayerStateMachinee : AbstractHierarchicalFiniteStateMachine
{
    public enum States
    {
        GROUNDED,
        AIR,
        GROUNDING
    }
    public PlayerStateMachinee()
    {
        Init(States.GROUNDED,
            Create<GroundedStateMachine, States>(States.GROUNDED, this),
            Create<AirStateMachine, States>(States.AIR, this),
            Create<LandStateMachine, States>(States.GROUNDING, this)
        );
    }
    public override void OnExitFromSubStateMachine(AbstractHierarchicalFiniteStateMachine subStateMachine)
    {
    }
    public override void OnStateMachineEntry()
    {
    }
    public override void OnStateMachineExit()
    {
    }
}
