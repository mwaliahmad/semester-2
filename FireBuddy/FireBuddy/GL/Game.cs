using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FireBuddy.GL
{
    public class Game
    {
        Player pacman;
        GameGrid grid;
        public List<Ghost> ghosts;
        int score = 0;
        Form gameGUI;
        public Game(Form gameGUI)
        {
            this.gameGUI = gameGUI;
            grid = new GameGrid("Maze1.txt", 26, 70);
            Image pacManImage = Game.getGameObjectImage('P');
            ghosts = new List<Ghost>();
            GameCell startCell = grid.getCell(8, 10);
            pacman = new Player(pacManImage, startCell);
            printMaze(grid);

        }
        public GameCell getCell(int x, int y)
        {
            return grid.getCell(x, y);
        }
        public void addGhost(Ghost ghost)
        {
            ghosts.Add(ghost);
        }
        public Player getPacManPlayer()
        {
            return pacman;
        }
        public void addScorePoints(int points)
        {
            this.score = score + points;
        }
        public int getScore()
        {
            return score;
        }
        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    gameGUI.Controls.Add(cell.PictureBox);
                }

            }
        }

        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, Properties.Resources.simplebox);
            return blankGameObject;
        }
        public Image getVerticalGhostImage()
        {
            return Properties.Resources.VM;
        }

        public Image getHorizontalGhostImage()
        {
            return Properties.Resources.HM;
        }

        /*public Image getPinkGhostImage()
        {
            return Properties.Resources.;
        }
        public Image getOrangeGhostImage()
        {
            return Properties.Resources.;
        }*/

        public static Image getGameObjectImage(char displayCharacter)
        {

            Image img = Properties.Resources.simplebox;


            if (displayCharacter == '#')
            {
                img = Properties.Resources.wall1;
            }

            /*if (displayCharacter == '#')
            {
                img = Properties.Resources.wall2;
            }*/

            if (displayCharacter == '.')
            {
                img = Properties.Resources.coin;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p')
            {
                img = Properties.Resources.Player;
            }

            return img;
        }
    }
}
