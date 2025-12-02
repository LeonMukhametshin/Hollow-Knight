using UnityEngine;

namespace PlayerStateMachine
{
    public class PlayerState : FsmState
    {
        protected readonly PlayerContext Context;
        protected IInputService PlayerInput => Context.Input;

        protected Vector2 MoveDirection { get; private set; }
        protected bool JumpPressed { get; private set; }
        protected bool IsRunning { get; private set; }

        public PlayerState(FSM fsm, PlayerContext context) : base(fsm)
        {
            Context = context;
        }

        public sealed override void Update()
        {
            UpdateCachedParameters();

            OnUpdate();
        }

        public sealed override void FixedUpdate()
        {
            OnFixedUpdate();
        }

        private void UpdateCachedParameters()
        {
            MoveDirection = PlayerInput.MoveDirection;
            JumpPressed = PlayerInput.JumpPressed; 
            IsRunning = PlayerInput.IsRunning;
        }

        protected bool HasMovementInput => MoveDirection.sqrMagnitude > 0.1f;

        public virtual void OnUpdate() { }

        public virtual void OnFixedUpdate() { }
    }
}