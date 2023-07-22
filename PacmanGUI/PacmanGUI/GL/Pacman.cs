using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PacmanGUI.GL
{
    public class Pacman : GameObject
    {
        public int Score = 0;
        public Pacman(Image image, GameCell startCell) : base(GameObjectType.PLAYER, image)
        {
            this.CurrentCell = startCell;
        }
        public GameCell move(GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                this.Score++;
                currentCell.setGameObject(Game.getBlankGameObject());
            }
            else if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
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


