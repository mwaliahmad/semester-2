using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FireBuddy.GL
{
    public class Fire : GameObject
    {
        GameDirection direction;
        bool stopped = false;
        public Fire(Image img, GameCell startCell, GameDirection direction) : base(GameObjectType.FIRE, img)
        {
            this.direction = direction;
            base.CurrentCell = startCell;
        }

        public bool Stopped { get => stopped; set => stopped = value; }

        public void move(GameCell gameCell)
        {
            if (base.CurrentCell != null)
            {
                base.CurrentCell.setGameObject(Game.getBlankGameObject());
            }
            base.CurrentCell = gameCell;

        }
        public GameCell nextCell()
        {
            GameCell gameCell = base.CurrentCell;
            GameCell gameCell2 = base.CurrentCell.nextCell(direction);
            if (gameCell2 == gameCell || gameCell2.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                Stopped = true;
            }
            else
            {
                gameCell = gameCell2;
            }
            return gameCell;
        }
    }
}
