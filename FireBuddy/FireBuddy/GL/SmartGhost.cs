using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FireBuddy.GL
{
   public class SmartGhost : Ghost
    {
        private GameDirection direction = GameDirection.Left;

        Game g;
        public SmartGhost(Image ghostImage, GameCell startCell, Game g)
            : base(ghostImage,GameObjectType.SM)
        {
            base.CurrentCell = startCell;
            this.g = g;
        }
        private GameDirection SetDirection()
        {
            int x = g.getPacManPlayer().CurrentCell.X;
            int y = g.getPacManPlayer().CurrentCell.Y;
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
            GameCell gameCell2 = base.CurrentCell.nextCell(SetDirection());

            return gameCell2;
        }
    }
}
