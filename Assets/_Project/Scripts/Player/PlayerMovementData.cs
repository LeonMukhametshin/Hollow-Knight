using UnityEngine;

[CreateAssetMenu(fileName = "PlayerMovementData", menuName = "Scriptable Objects/PlayerMovementData")]
public class PlayerMovementData : ScriptableObject
{
    public float Speed => m_speed;
    public float JumpForce => m_jumpForce;
    public float CheckGroundRadius => m_checkGroundRadius;

    [SerializeField] private float m_speed;
    [SerializeField] private float m_jumpForce;
    [SerializeField] private float m_checkGroundRadius;
}