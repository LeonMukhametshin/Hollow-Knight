using UnityEngine;

namespace Player
{
    public interface IControllable
    {
        void Move(Vector3 direction);
        void Jump();
    }
}