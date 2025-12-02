using UnityEngine;

public class BoosterInteractor : MonoBehaviour
{
    [SerializeField] private PlayerController m_playerStatesController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IBoosterLoot boosterLoot = collision.GetComponent<IBoosterLoot>();

        if (boosterLoot is not null)
        {
            
        }
    }
}
