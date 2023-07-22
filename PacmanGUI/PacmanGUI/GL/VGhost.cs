using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PacmanGUI.GL
{
    class VGhost : Ghost
    {
        GameDirection direction = GameDirection.Up;
        public VGhost(Image image, GameCell startCell) : base(image, startCell)
        {
        }
        public override GameCell move()
        {
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
