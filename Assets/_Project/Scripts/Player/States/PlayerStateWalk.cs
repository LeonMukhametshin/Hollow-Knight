using UnityEngine;

public class PlayerStateWalk : PlayerStateMovement
{
    public PlayerStateWalk(FSM fsm, Transform transform, float speed) : base(fsm, transform, speed) { }

    public override void Update()
    {
        Debug.Log($"Walk state UPDATE with speed: {Speed}");

        var inputDirection = ReadInput();

        if (inputDirection.sqrMagnitude == 0f)
        {
            Fsm.SetState<PlayerStateIdle>();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Fsm.SetState<PlayerStateRun>();
        }

        Move(inputDirection);
    }
}