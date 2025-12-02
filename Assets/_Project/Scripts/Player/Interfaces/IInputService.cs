using System;
using UnityEngine;

public interface IInputService
{
    Vector2 MoveDirection { get; }
    bool IsRunning { get; }
    bool JumpPressed { get; }

    void Update();
}