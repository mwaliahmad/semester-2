using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGUI.GL
{
    class RGhost : Ghost
    {
        GameDirection direction = GameDirection.Right;
        public RGhost(Image image, GameCell startCell) : base(image, startCell)
        {
        }

        public override GameCell move()
        {
            GameDirection[] Select = new GameDirection[] { GameDirection.Down, GameDirection.Up, GameDirection.Right, GameDirection.Left };
            Random number = new Random();
            int i = number.Next(4);
            this.direction = Select[i];
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(ref this.direction);
            
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                currentCell.setGameObject(Game.getRewardGameObject());
            }
            else if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                return null;
            }
            else
            {
                currentCell.setGameObject(Game.getBlankGameObject());
            }

            this.CurrentCell = nextCell;
            return nextCell;
        }
    }
}
