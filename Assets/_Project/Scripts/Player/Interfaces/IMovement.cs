using UnityEngine;

public interface IMovement
{
    void Move(Rigidbody2D rigidbody, Vector2 direction, float speed);
    void Stop(Rigidbody2D rigidbody);
    bool CanMove();
}