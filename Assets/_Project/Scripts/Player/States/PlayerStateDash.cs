using PlayerStateMachine;

public class PlayerStateDash : PlayerState
{
    private IDash m_dash;

    public PlayerStateDash(FSM fsm, PlayerContext context, IDash dash) : base(fsm, context)
    {
        m_dash = dash;
    }

    public override void Enter()
    {
        m_dash.Do();
        Fsm.SetState<PlayerStateIdle>();
    }
}