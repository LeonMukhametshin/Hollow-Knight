using UnityEngine;

public class InputService : IInputService
{
    private GameInput m_gameInput;

    public Vector2 MoveDirection { get; private set; }
    public bool IsRunning { get; private set; }
    public bool JumpPressed { get; private set; }
    public bool IsDash { get; private set; }

    public InputService()
    {
        m_gameInput = new GameInput();
        m_gameInput.Enable();
    }

    public void Update()
    {
        MoveDirection = m_gameInput.Gameplay.Movement.ReadValue<Vector2>();

        IsRunning = m_gameInput.Gameplay.Run.IsPressed();
        JumpPressed = m_gameInput.Gameplay.Jump.WasPressedThisFrame();
        IsDash = m_gameInput.Gameplay.Dash.WasPressedThisFrame();
    }
}