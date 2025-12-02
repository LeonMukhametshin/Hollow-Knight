using UnityEngine;

namespace PlayerStateMachine
{
    public class PlayerStateIdle : PlayerState
    {
        public PlayerStateIdle(FSM fsm, PlayerContext context) : base(fsm, context) { }

        public override void Enter()
        {
            Context.Rigidbody.linearVelocity = new Vector2(0, Context.Rigidbody.linearVelocity.y);
        }

        public override void OnUpdate()
        {
            Debug.Log("IDLE");
            if (MoveDirection.sqrMagnitude > 0.1f)
            {
                if(IsRunning)
                {
                    Fsm.SetState<PlayerStateRun>();
                }
                else
                {
                    Fsm.SetState<PlayerStateWalk>();
                }
            }

            if(JumpPressed)
            {
                Fsm.SetState<PlayerStateJump>();
            }
        }
    }
}