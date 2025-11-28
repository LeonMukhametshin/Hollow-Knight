using UnityEngine;

[CreateAssetMenu(fileName = "FollowerData", menuName = "Scriptable Objects/FollowerData")]
public class FollowerData : ScriptableObject
{
    public Vector3 Offset => m_offset;
    public float Smoothing => m_smoothing;

    [SerializeField] private Vector3 m_offset;
    [SerializeField][Range(1, 10)] private float m_smoothing;
}