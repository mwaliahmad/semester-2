using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireBuddy.GL
{
    public class CollisionDetection
    {
        public bool isGhostCollideWithPlayer(Ghost ghost)
        {
            bool flag = false;
            if (ghost.CurrentCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                flag = true;
            }
            return flag;
        }

        public bool isPlayerCollideWithCoin(GameCell potentialCell)
        {
            bool flag = false;
            if (potentialCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                flag = true;
            }
            return flag;

        }
        public bool isEnemyCollideWithBullet(Fire f)
        {
            bool flag = false;
            if (f.nextCell().CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
            {
                flag = true;
                f.Stopped = true;
            }

            return flag;
        }
    }
}

