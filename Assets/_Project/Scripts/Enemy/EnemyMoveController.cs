using UnityEngine;

public class EnemyMoveController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D m_rigidbody2D;
    [SerializeField] private Animator m_animator;

    private Vector2 m_horizontalVelocity;
    private Vector3 m_leftFlip = new Vector3(0, 180, 0);
    private float m_singPreviousFrame;
    private float m_singCurrentFrame;

    private void Update()
    {
        Flip();
    }

    public void Move(float speed)
    {
        m_horizontalVelocity.Set(speed, m_rigidbody2D.linearVelocity.y);
        m_rigidbody2D.linearVelocity = m_horizontalVelocity; 
    }

    private void Flip()
    {
        m_singCurrentFrame = m_rigidbody2D.linearVelocityX == 0 ? m_singPreviousFrame : Mathf.Sign(m_rigidbody2D.linearVelocityX);
    
        if(m_singCurrentFrame != m_singPreviousFrame)
        {
            transform.rotation = Quaternion.Euler(m_rigidbody2D.linearVelocityX < 0 ? m_leftFlip : Vector3.zero);
        }
        m_singPreviousFrame = m_singCurrentFrame;
    }
}
