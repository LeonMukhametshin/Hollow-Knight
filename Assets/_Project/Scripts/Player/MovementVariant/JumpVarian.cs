using PlayerStateMachine;
using UnityEngine;

public class JumpVarian : IJump
{
    public void Jump(Rigidbody2D rigidbody, float force)
    {
        rigidbody.linearVelocity = new Vector2(rigidbody.linearVelocity.x, force);
    }
}