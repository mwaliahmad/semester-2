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
        public bool isGhostCollideWithBullet(Ghost ghost)
        {
            bool flag = false;
            if (ghost.nextCell().CurrentGameObject.GameObjectType == GameObjectType.FIRE)
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
        public bool isHMCollideWithBullet(Fire f)
        {
            bool flag = false;
            if (f.nextCell().CurrentGameObject.GameObjectType == GameObjectType.HM)
            {
                f.Stopped = true;
                flag = true;
            }
            return flag;
        }
        public bool isVMCollideWithBullet(Fire f)
        {
            bool flag = false;
            if (f.nextCell().CurrentGameObject.GameObjectType == GameObjectType.VM)
            {
                f.Stopped = true;
                flag = true;
            }
            return flag;
        }
        public bool isRMCollideWithBullet(Fire f)
        {
            bool flag = false;
            if (f.nextCell().CurrentGameObject.GameObjectType == GameObjectType.RM)
            {
                f.Stopped = true;
                flag = true;
            }
            return flag;
        }
        public bool isSMCollideWithBullet(Fire f)
        {
            bool flag = false;
            if (f.nextCell().CurrentGameObject.GameObjectType == GameObjectType.SM)
            {
                f.Stopped = true;
                flag = true;
            }
            return flag;
        }
    }
}

