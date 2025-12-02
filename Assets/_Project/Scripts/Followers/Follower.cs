using UnityEngine;

namespace Follower
{
    public abstract class Follower : MonoBehaviour
    {
        [SerializeField] private Transform m_targetTransform;
        [SerializeField] private FollowerData m_data;

        protected void Move(float deltaTime)
        {
            var nextPosition = Vector3.Lerp(
                transform.position, 
                m_targetTransform.position + m_data.Offset, 
                deltaTime * m_data.Smoothing);

            transform.position = nextPosition;
        }
    }
}
