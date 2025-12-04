namespace PlayerStateMachine
{
    public class PlayerStateJump : PlayerState
    {
        private IJump m_jump;

        public PlayerStateJump(FSM fsm, PlayerContext context, IJump jump) : base(fsm, context)
        {
            m_jump = jump;
        }

        public override void Enter()
        {
            m_jump.Jump(Context.Rigidbody, Context.PlayerData.JumpForce);
            Fsm.SetState<PlayerStateIdle>();
        }
    }
}