using UnityEngine;

namespace PlayerStateMachine
{
    public interface IJump
    {
        void Jump(Rigidbody2D rigidbody, float force);
    }
}