using PacmanGUI.GL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace PacmanGUI
{
    public partial class Form1 : Form
    {
        Pacman pacman;
        List<Ghost> ghosts = new List<Ghost>();
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            #region Player Movement
            GameCell cell = new GameCell();
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                cell = pacman.move(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                cell = pacman.move(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                cell = pacman.move(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                cell = pacman.move(GameDirection.Down);
            }
            #endregion
            score.Text = pacman.Score.ToString();

            #region Player Collision
            if (cell == null)
            {
                GameLoop.Stop();
                MessageBox.Show("G A M E  'P'  O V E R ");
                Application.Exit();
            }
            #endregion

            #region Ghost movement and Collision Loop
            foreach (Ghost g in ghosts)
            {
                if (g.move() == null)
                {
                    GameLoop.Stop();
                    MessageBox.Show("G A M E  'G'  O V E R ");
                }
                else
                {
                    g.move();
                }
            }
            #endregion
        }


        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);
                    //        printCell(cell);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameGrid grid = new GameGrid("maze.txt", 24, 71);

            GameCell startCell1 = grid.getCell(8, 10);
            GameCell startCell2 = grid.getCell(1, 3);
            GameCell startCell3 = grid.getCell(2, 2);
            GameCell startCell4 = grid.getCell(1, 66);
            GameCell startCell5 = grid.getCell(21, 3);


            pacman = new Pacman(Game.getGameObjectImage('P'), startCell1);
            HGhost hGhost = new HGhost(Game.getGameObjectImage('H'), startCell2);
            VGhost vGhost = new VGhost(Game.getGameObjectImage('V'), startCell3);
            RGhost rGhost = new RGhost(Game.getGameObjectImage('R'), startCell4);
            SGhost sGhost = new SGhost(Game.getGameObjectImage('S'), startCell5);

            ghosts.Add(hGhost);
            ghosts.Add(vGhost);
            ghosts.Add(rGhost);
            ghosts.Add(sGhost);

            score.Text = pacman.Score.ToString();
            printMaze(grid);
        }
    }
}
