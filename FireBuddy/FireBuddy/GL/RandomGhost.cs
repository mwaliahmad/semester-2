using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FireBuddy.GL
{
    public class RandomGhost : Ghost
    {
        private GameDirection direction = GameDirection.Left;
        public RandomGhost(Image ghostImage, GameCell startCell)
            : base(ghostImage, GameObjectType.RM)
        {
            base.CurrentCell = startCell;
        }

        public override void move(GameCell gameCell)
        {

            if (CurrentCell != null)
            {
                base.CurrentCell.setGameObject(Game.getBlankGameObject());
            }

            base.CurrentCell = gameCell;
            
        }

        public override GameCell nextCell()
        {
            GameDirection[] Select = new GameDirection[] { GameDirection.Down, GameDirection.Up, GameDirection.Right, GameDirection.Left };
            Random number = new Random();
            int i = number.Next(4);
            this.direction = Select[i];
            GameCell gameCell = base.CurrentCell;
            GameCell gameCell2 = base.CurrentCell.nextCell(direction);
            if (gameCell2 == gameCell)
            {
                int j = number.Next(4);
                this.direction = Select[j];
            }
            else
            {
                gameCell = gameCell2;
            }

            return gameCell;
        }
    }
}
