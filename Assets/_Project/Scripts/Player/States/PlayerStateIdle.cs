using UnityEngine;

public class PlayerStateIdle : FsmState
{
    public PlayerStateIdle(FSM fsm) : base(fsm) { }

    public override void Enter()
    {
        Debug.Log("Idle state ENTER");
    }

    public override void Exit()
    {
        Debug.Log("Idle state EXIT");
    }

    public override void Update()
    {
        Debug.Log("Idle state UPDATE");
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetAxis("Horizontal") != 0)
        {
            Fsm.SetState<PlayerStateRun>();
            return;
        }

        if(Input.GetAxis("Horizontal") != 0)
        {
            Fsm.SetState<PlayerStateWalk>();
        }
    }
}