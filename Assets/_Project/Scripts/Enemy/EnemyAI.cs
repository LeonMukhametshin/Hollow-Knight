using UnityEngine;

public class EnemyAI : DamagableObject
{
    public float Speed { get; }

    [SerializeField] private EnemyMoveController m_moveController;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        m_moveController.Move(Speed);
    }
}
