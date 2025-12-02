using UnityEngine;
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
                return;
            }

            if (!HasMovementInput)
            {
                Fsm.SetState<PlayerStateIdle>();
                return;
            }
            
            if (JumpPressed)
            {
                Fsm.SetState<PlayerStateJump>();
                return;
            }
        }

        public override void OnFixedUpdate()
        {   
            m_movement.Move(Context.Rigidbody, MoveDirection, Context.PlayerData.RunSpeed);
        }
    }
}