using UnityEngine;

namespace Follower
{
    public class FollowerFixedUpdate : Follower
    {
        private void FixedUpdate()
        {
            Move(Time.fixedDeltaTime);
        }
    }
}