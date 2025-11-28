using UnityEngine;

namespace Player
{
    public class CharacterInputController : MonoBehaviour
    {
        private IControllable m_controllable;
        private GameInput m_gameInput;

        private void OnValidate()
        {
            if (m_controllable is null)
            {
                m_controllable = GetComponent<IControllable>();
            }
        }

        private void Awake()
        {
            InitializeGameInput();
        }

        private void OnEnable()
        {
            m_gameInput.Gameplay.Jump.performed += JumpPerformed;
        }

        private void OnDisable()
        {
            m_gameInput.Gameplay.Jump.performed -= JumpPerformed;
        }

        private void Update()
        {
            ReadMovement(); 
        }

        private void InitializeGameInput()
        {
            m_gameInput = new GameInput();
            m_gameInput.Enable();
        }

        private void ReadMovement()
        {
            var inputDirection = m_gameInput.Gameplay.Movement.ReadValue<Vector2>();
            var direction = new Vector3(inputDirection.x, 0f, 0f);

            m_controllable.Move(direction);
        }

        private void JumpPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            m_controllable.Jump();
        }
    }
}