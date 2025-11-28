using UnityEngine;

namespace Follower
{
    public abstract class Follower : MonoBehaviour
    {
        [SerializeField] private Transform m_targetTransform;
        [SerializeField] private Vector3 m_offcet;
        [SerializeField][Range(1, 10)] private float m_smoothing = 1.5f;

        protected void Move(float deltaTime)
        {
            var nextPosition = Vector3.Lerp(transform.position, m_targetTransform.position + m_offcet, deltaTime * m_smoothing);

            transform.position = nextPosition;
        }
    }
}
