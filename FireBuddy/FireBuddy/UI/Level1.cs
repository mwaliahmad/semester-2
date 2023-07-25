using EZInput;
using FireBuddy.GL;
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FireBuddy.UI
{
    public partial class Level1 : Form
    {
        Game game;
        CollisionDetection collider;
        char movementStatus = 's';
        public Level1()
        {
            InitializeComponent();
            game = new Game("Maze1.txt", this, 26, 68);
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
            moveDown();
            MoveFire();
            game.RemoveFire();
            /*if (Keyboard.IsKeyPressed(Key.Escape))
            {
                setMenu();
            }*/
            showScore();
        }
        private void MoveFire()
        {

            foreach (Fire f in game.Fires)
            {
                if (collider.isEnemyCollideWithBullet(f))
                {
                    // game.Turtle1.Health = game.Turtle1.Health - 5;
                }
                f.move(f.nextCell());
            }
        }
        public void setMenu()
        {
            GameLoop.Stop();
            Menu form = new Menu();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.BringToFront();
            form.resume_btn += Form_resume_btn;
            form.menu_btn += Form_menu_btn;
            form.Show();
        }

        private void Form_menu_btn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_resume_btn(object sender, EventArgs e)
        {
            GameLoop.Start();
        }

        public void moveGhosts()
        {
            foreach (Ghost g in game.ghosts)
            {
                if (collider.isGhostCollideWithPlayer(g))
                {
                    game.addScorePoints(-1);
                }
                g.move(g.nextCell());


            }
        }
        private void showScore()
        {
            score.Text = game.getScore().ToString();
        }
        private void movePlayer()
        {
            Player player = game.getPacManPlayer();
            GameCell potentialNewCell = player.CurrentCell;
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                potentialNewCell = player.CurrentCell.nextCell(GameDirection.Left);
                GameCell currentCell = player.CurrentCell;
                currentCell.setGameObject(Game.getBlankGameObject());
                player.move(potentialNewCell);
                movementStatus = 'd';
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                potentialNewCell = player.CurrentCell.nextCell(GameDirection.Right);
                GameCell currentCell = player.CurrentCell;
                currentCell.setGameObject(Game.getBlankGameObject());
                player.move(potentialNewCell);
                movementStatus = 'd';
                if (collider.isPlayerCollideWithCoin(potentialNewCell))
                {
                    game.addScorePoints(1);
                }
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                int jumpCount = 0;
                for (int i = 0; i < 3; i++)
                {
                    potentialNewCell = player.CurrentCell.nextCell(GameDirection.Up);
                    jumpCount++;
                    GameCell currentCell = player.CurrentCell;
                    currentCell.setGameObject(Game.getBlankGameObject());
                    player.move(potentialNewCell);
                }

                if (jumpCount == 3)
                {
                    movementStatus = 'd';

                }
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                GameCell NewCell = player.CurrentCell.nextCell(GameDirection.Right);
                Fire f = new Fire(Properties.Resources.bullet, NewCell, GameDirection.Right);
                game.addFire(f);
            }
            
        }
        private void moveDown()
        {
            Player mario = game.player;
            GameCell potentialNewCell = mario.CurrentCell;
            GameCell nextCell;
            if (movementStatus == 'd')
            {
                nextCell = mario.CurrentCell.nextCell(GameDirection.Down);
                if (nextCell != potentialNewCell)
                {
                    GameCell currentCell = mario.CurrentCell;
                    currentCell.setGameObject(Game.getBlankGameObject());
                    mario.move(nextCell);
                }
                else
                {
                    movementStatus = 's';
                }
            }
        }
    }
}
