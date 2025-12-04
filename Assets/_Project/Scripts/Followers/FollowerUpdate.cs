using UnityEngine;

namespace Follower
{
    public class FollowerUpdate : Follower
    {
        private void Update()
        {
            Move(Time.deltaTime);
        }
    }
}