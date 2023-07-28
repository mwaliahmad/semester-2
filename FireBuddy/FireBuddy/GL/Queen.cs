using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FireBuddy.GL
{
    public class Queen : Ghost
    {
        GameDirection direction = GameDirection.Down;

        public Queen(Image ghostImage, GameCell startCell) : base(ghostImage, GameObjectType.QUEEN)
        {
            this.CurrentCell = startCell;
        }

        public override void move(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.setGameObject(Game.getBlankGameObject());

            }
            CurrentCell = gameCell;
        }

        public override GameCell nextCell()
        {

            GameCell nextCell = this.CurrentCell;

            GameCell potentialNextCell = this.CurrentCell.nextCell(direction);


            nextCell = potentialNextCell;

            return nextCell;

        }

    }
}
