using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireBuddy.GL
{
    public class GameCell
    {
        int row;
        int col;
        GameObject currentGameObject;
        GameGrid grid;
        PictureBox pictureBox;
        const int width = 20;
        const int height = 20;
        
        public GameCell()
        {

        }
        public GameCell(int row, int col, GameGrid grid)
        {
            this.row = row;
            this.col = col;
            pictureBox = new PictureBox();
            pictureBox.Left = col * width;
            pictureBox.Top = row * height;
            pictureBox.Size = new Size(width, height);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BackColor = Color.Transparent;
            this.grid = grid;
        }
        public void setGameObject(GameObject gameObject)
        {
            currentGameObject = gameObject;
            pictureBox.Image = gameObject.Image;

        }
        public GameCell nextCell(GameDirection direction)
        {
            if (direction == GameDirection.Left && col > 0)
            {
                GameCell cell = grid.getCell(row, col - 1);
                if (cell.CurrentGameObject.GameObjectType == GameObjectType.NONE || cell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER || cell.CurrentGameObject.GameObjectType == GameObjectType.HM || cell.CurrentGameObject.GameObjectType == GameObjectType.VM|| cell.CurrentGameObject.GameObjectType == GameObjectType.RM || cell.CurrentGameObject.GameObjectType == GameObjectType.SM || cell.CurrentGameObject.GameObjectType == GameObjectType.REWARD || cell.CurrentGameObject.GameObjectType == GameObjectType.HOLE || cell.CurrentGameObject.GameObjectType == GameObjectType.QUEEN)
                {
                    return cell;
                }
            }

            if (direction == GameDirection.Right && col < grid.Cols - 1)
            {
                GameCell cell2 = grid.getCell(row, col + 1);
                if (cell2.CurrentGameObject.GameObjectType == GameObjectType.NONE || cell2.CurrentGameObject.GameObjectType == GameObjectType.PLAYER || cell2.CurrentGameObject.GameObjectType == GameObjectType.HM || cell2.CurrentGameObject.GameObjectType == GameObjectType.VM || cell2.CurrentGameObject.GameObjectType == GameObjectType.RM || cell2.CurrentGameObject.GameObjectType == GameObjectType.SM || cell2.CurrentGameObject.GameObjectType == GameObjectType.REWARD || cell2.CurrentGameObject.GameObjectType == GameObjectType.HOLE || cell2.CurrentGameObject.GameObjectType == GameObjectType.QUEEN)
                {
                    return cell2;
                }
            }

            if (direction == GameDirection.Up && row > 0)
            {
                GameCell cell3 = grid.getCell(row - 1, col);
                if (cell3.CurrentGameObject.GameObjectType == GameObjectType.NONE || cell3.CurrentGameObject.GameObjectType == GameObjectType.PLAYER || cell3.CurrentGameObject.GameObjectType == GameObjectType.HM || cell3.CurrentGameObject.GameObjectType == GameObjectType.VM || cell3.CurrentGameObject.GameObjectType == GameObjectType.RM || cell3.CurrentGameObject.GameObjectType == GameObjectType.SM || cell3.CurrentGameObject.GameObjectType == GameObjectType.REWARD || cell3.CurrentGameObject.GameObjectType == GameObjectType.HOLE || cell3.CurrentGameObject.GameObjectType == GameObjectType.QUEEN)
                {
                    return cell3;
                }
            }

            if (direction == GameDirection.Down && row < grid.Rows - 2)
            {
                GameCell cell4 = grid.getCell(row + 1, col);
                if (cell4.CurrentGameObject.GameObjectType == GameObjectType.NONE || cell4.CurrentGameObject.GameObjectType == GameObjectType.PLAYER || cell4.CurrentGameObject.GameObjectType == GameObjectType.HM || cell4.CurrentGameObject.GameObjectType == GameObjectType.VM || cell4.CurrentGameObject.GameObjectType == GameObjectType.RM || cell4.CurrentGameObject.GameObjectType == GameObjectType.SM || cell4.CurrentGameObject.GameObjectType == GameObjectType.REWARD || cell4.CurrentGameObject.GameObjectType == GameObjectType.QUEEN || cell4.CurrentGameObject.GameObjectType == GameObjectType.HOLE)
                {
                    return cell4;
                }
            }

            return this;
        }
        public int X { get => row; set => row = value; }
        public int Y { get => col; set => col = value; }
        public GameObject CurrentGameObject { get => currentGameObject; }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }
    }
}
