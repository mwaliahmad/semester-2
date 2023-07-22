using FireBuddy.GL;
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
namespace FireBuddy.UI
{
    public partial class Level1 : Form
    {
        Game game;
        CollisionDetection collider;
        public Level1()
        {
            InitializeComponent();
            game = new Game(this);
            collider = new CollisionDetection();
        }

        private void Level1_Load(object sender, EventArgs e)
        {
            VerticalGhost gv1 = new VerticalGhost(game.getVerticalGhostImage(), game.getCell(3, 6));
            VerticalGhost gv2 = new VerticalGhost(game.getHorizontalGhostImage(), game.getCell(3, 22));

            game.addGhost(gv1);
            game.addGhost(gv2);
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            movePlayer();
            moveGhosts();
            // showScore();
        }
        public void moveGhosts()
        {
            foreach (Ghost g in game.ghosts)
            {
                if (collider.isGhostCollideWithPacMan(g))
                {
                    game.addScorePoints(-1);
                }
                g.move(g.nextCell());


            }
        }
        /*private void showScore()
        {

            lblScoreValue.Text = game.getScore().ToString();
        }*/
        private void movePlayer()
        {
            Player player = game.getPacManPlayer();
            GameCell potentialNewCell = player.CurrentCell;
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                potentialNewCell = player.CurrentCell.nextCell(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                potentialNewCell = player.CurrentCell.nextCell(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                potentialNewCell = player.CurrentCell.nextCell(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                potentialNewCell = player.CurrentCell.nextCell(GameDirection.Down);
            }
            GameCell currentCell = player.CurrentCell;
            currentCell.setGameObject(Game.getBlankGameObject());
            /*if (collider.isPacManCollideWithPallet(potentialNewCell))
            {
                game.addScorePoints(1);
            }*/
            player.move(potentialNewCell);
        }
    }
}
