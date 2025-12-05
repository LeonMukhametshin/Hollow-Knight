using UnityEngine;

public class DamagableObject : MonoBehaviour
{
    [SerializeField] private float m_healthPoints;

    public void TakeDamage(float damage)
    {
        m_healthPoints -= damage;

        if(m_healthPoints < 0 )
        {
            Die();
        }

        Debug.Log($"Hit with damage: {damage}");
    }

    private void Die()
    {
        Destroy(this.gameObject);
    }
}
