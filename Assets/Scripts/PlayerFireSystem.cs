using UnityEngine;

namespace Kaeru
{
    /// <summary>
    /// 玩家發射
    /// </summary>
    public class PlayerFireSystem : FireSystemBase
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    }
}

