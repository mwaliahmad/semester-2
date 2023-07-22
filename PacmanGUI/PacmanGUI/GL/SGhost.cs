using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PacmanGUI.GL
{
    class SGhost : Ghost
    {
        GameDirection direction = GameDirection.Down;
        public SGhost(Image image, GameCell startCell) : base(image, startCell)
        {
        }
        public GameDirection SetDirection()
        {
            int x = SearchPacman().X;
            int y = SearchPacman().Y;
            if (x > CurrentCell.X)
            {
                direction = GameDirection.Down;
            }
            else if (y > CurrentCell.Y)
            {
                direction = GameDirection.Right;
            }
            else if (x < CurrentCell.X)
            {
                direction = GameDirection.Up;
            }
            else if (y < CurrentCell.Y)
            {
                direction = GameDirection.Left;
            }
            return direction;
        }
        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(SetDirection());
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
        public GameCell SearchPacman()
        {
            for (int i = 0; i < this.CurrentCell.grid.Rows; i++)
            {
                for (int j = 0; j < this.CurrentCell.grid.Cols; j++)
                {
                    if (this.CurrentCell.grid.cells[i, j].CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                    {
                        return this.CurrentCell.grid.cells[i, j];
                    }
                }
            }
            return null;
        }
    }
}
