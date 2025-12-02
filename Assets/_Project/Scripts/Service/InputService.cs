using System;
using UnityEngine;

public class InputService : IInputService
{
    private GameInput m_gameInput;

    private Vector2 m_moveDirection;
    private bool m_isRunning;
    private bool m_jumpPressed;

    public Vector2 MoveDirection => m_moveDirection;
    public bool IsRunning => m_isRunning;
    public bool JumpPressed => m_jumpPressed;

    public InputService()
    {
        m_gameInput = new GameInput();
        m_gameInput.Enable();
    }

    public void Update()
    {
        m_moveDirection = m_gameInput.Gameplay.Movement.ReadValue<Vector2>();

        m_isRunning = m_gameInput.Gameplay.Run.IsPressed();
        m_jumpPressed = m_gameInput.Gameplay.Jump.WasPressedThisFrame();
    }
}