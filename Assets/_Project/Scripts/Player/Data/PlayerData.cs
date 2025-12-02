using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private float m_walkSpeed;
    [SerializeField] private float m_runSpeed;
    [SerializeField] private float m_jumpForce;

    public float WalkSpeed => m_walkSpeed;
    public float RunSpeed => m_runSpeed;
    public float JumpForce => m_jumpForce;
}