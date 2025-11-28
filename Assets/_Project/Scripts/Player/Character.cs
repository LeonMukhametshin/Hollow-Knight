using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Character : MonoBehaviour, IControllable
    {
        [SerializeField] private Rigidbody2D m_rigidbody;
        [SerializeField] private float m_speed = 10;
        [SerializeField] private float m_jumpForce = 12f;

        [SerializeField] private Transform m_groundCheckerPoint;
        [SerializeField] private float m_checkGroundRadius = 0.4f;
        [SerializeField] private LayerMask m_groundMask;

        private Vector2 m_moveDirection;
        private bool m_isGrounded;

        private void OnValidate()
        {
            if(m_rigidbody is null)
            {
                m_rigidbody = GetComponent<Rigidbody2D>();
            }
        }

        private void FixedUpdate()
        {
            m_isGrounded = IsOnTheGround();

            MoveInternal();
        }

        public void Jump()
        {
            if(m_isGrounded)
            {
                m_rigidbody.linearVelocity = new Vector2(m_rigidbody.linearVelocity.x, m_jumpForce);
            }
        }

        public void Move(Vector3 direction)
        {
            m_moveDirection = direction;
        }

        private void MoveInternal()
        {
            m_rigidbody.linearVelocity = new Vector2(m_moveDirection.x * m_speed, m_rigidbody.linearVelocity.y);
        }

        private bool IsOnTheGround() =>
            Physics2D.OverlapCircle(m_groundCheckerPoint.position, m_checkGroundRadius, m_groundMask);
    }
}