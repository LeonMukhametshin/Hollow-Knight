using UnityEngine;

public class MeleeAttackController : MonoBehaviour
{
    [SerializeField] private Transform m_attackPoint;
    [SerializeField] private Animation m_animator;
    [SerializeField] private LayerMask m_damageableLayerMask;

    [SerializeField] private float m_damage;
    [SerializeField] private float m_attackRange;
    [SerializeField] private float m_timeBetweenAttack;

    private float m_timer;

    private void Update()
    {
        Attack();
    }

    private void Attack()
    {
        if(m_timer <= 0)
        {
            if(Input.GetButtonDown("Fire1"))
            {
                Collider2D[] enemies = Physics2D.OverlapCircleAll(m_attackPoint.position, m_attackRange, m_damageableLayerMask);

                if(enemies.Length > 0)
                {
                    foreach(var enemy in enemies)
                    {
                        enemy.GetComponent<DamagableObject>().TakeDamage(m_damage);
                    }
                }
                m_timer = m_timeBetweenAttack;  
            }
        }
        else
        {
            m_timer -= Time.deltaTime;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.aquamarine;
        Gizmos.DrawWireSphere(m_attackPoint.position, m_attackRange);
    }
}
