using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FireBuddy.GL
{
    public class HorizontalGhost : Ghost
    {
        private GameDirection direction = GameDirection.Left;
        private int health = 100;
        public HorizontalGhost(Image ghostImage, GameCell startCell)
            : base(ghostImage)
        {
            base.CurrentCell = startCell;
        }

        public override void move(GameCell gameCell)
        {
            if (base.CurrentCell != null)
            {
                base.CurrentCell.setGameObject(Game.getBlankGameObject());
            }

            base.CurrentCell = gameCell;
        }

        public override GameCell nextCell()
        {
            GameCell gameCell = base.CurrentCell;
            GameCell gameCell2 = base.CurrentCell.nextCell(direction);
            if (gameCell2 == gameCell)
            {
                if (direction == GameDirection.Left)
                {
                    direction = GameDirection.Right;
                }
                else if (direction == GameDirection.Right)
                {
                    direction = GameDirection.Left;
                }
            }
            else
            {
                gameCell = gameCell2;
            }

            return gameCell;
        }
    }
}
