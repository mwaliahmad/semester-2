using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FireBuddy.GL
{
    public class Player : GameObject
    {
        private int health = 100;
        public Player(Image image, GameCell startCell) : base(GameObjectType.PLAYER, image)
        {
            this.CurrentCell = startCell;
        }

        public void move(GameCell gameCell)
        {
            CurrentCell = gameCell;
        }

    }


}
