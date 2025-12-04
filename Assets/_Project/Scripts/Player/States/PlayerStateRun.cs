namespace PlayerStateMachine
{
    public class PlayerStateRun : PlayerState
    {
        private IMovement m_movement;

        public PlayerStateRun(FSM fsm, PlayerContext context, IMovement movement) : base(fsm, context)
        {
            m_movement = movement;
        }

        public override void OnUpdate()
        {
            if (!IsRunning)
            {
                Fsm.SetState<PlayerStateWalk>();
            }

            if (!HasMovementInput)
            {
                Fsm.SetState<PlayerStateIdle>();
            }
            
            if(IsDash)
            {
                Fsm.SetState<PlayerStateDash>();
            }

            if (JumpPressed)
            {
                Fsm.SetState<PlayerStateJump>();
            }
        }

        public override void OnFixedUpdate()
        {   
            m_movement.Move(Context.Rigidbody, MoveDirection, Context.PlayerData.RunSpeed);
        }
    }
}