using UnityEngine;

public class VelocityMovement : IMovement
{
    private bool m_canMove = true;

    public void Move(Rigidbody2D rigidbody, Vector2 direction, float speed)
    {
        if(!m_canMove)
        {
            return;
        }

        rigidbody.linearVelocity = new Vector2(
            direction.x * speed,
            rigidbody.linearVelocity.y
        );
    }

    public bool SetCatMove(bool canMove) => m_canMove = canMove;

    public bool CanMove() => m_canMove;

    public void Stop(Rigidbody2D rigidbody)
    {
        rigidbody.linearVelocity = new Vector2(0, rigidbody.linearVelocity.y);
    }
}