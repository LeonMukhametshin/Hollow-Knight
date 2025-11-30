using UnityEngine;

public class PlayerStateMovement : FsmState
{
    protected readonly Transform m_transform;
    protected readonly float Speed;

    public PlayerStateMovement(FSM fsm, Transform transform, float speed) : base(fsm)
    {
        m_transform = transform;
        Speed = speed;
    }

    public override void Enter()
    {
        Debug.Log($"Movement ({this.GetType().Name}) state ENTER");
    }

    public override void Exit()
    {
        Debug.Log($"Movement ({this.GetType().Name}) state EXIT");
    }

    public override void Update()
    {
        Debug.Log($"Movement ({this.GetType().Name}) state UPDATE with speed: {Speed}");

        var inputDirection = ReadInput();

        if(inputDirection.sqrMagnitude == 0f)
        {
            Fsm.SetState<PlayerStateIdle>();
        }

        Move(inputDirection);
    }

    protected Vector2 ReadInput()
    {
        var inputHorizontal = Input.GetAxis("Horizontal");
        var inputVertical = Input.GetAxis("Vertical");
        var inputDirection = new Vector2(inputHorizontal, inputVertical);

        return inputDirection;
    }

    protected virtual void Move(Vector2 inputDirection)
    {
        m_transform.position += new Vector3(inputDirection.x, 0f, 0f) * (Speed * Time.deltaTime);
    }
}
