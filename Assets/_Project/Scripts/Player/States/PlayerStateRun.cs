using UnityEngine;

public class PlayerStateRun : PlayerStateMovement
{
    public PlayerStateRun(FSM fsm, Transform transform, float speed) : base(fsm, transform, speed) { }

    public override void Update()
    {
        Debug.Log($"Run state UPDATE with speed: {Speed}");

        var inputDirection = ReadInput();

        if (inputDirection.sqrMagnitude == 0f)
        {
            Fsm.SetState<PlayerStateIdle>();
        }

        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            Fsm.SetState<PlayerStateWalk>();
        }

        Move(inputDirection);
    }
}
