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
        GameDirection direct = GameDirection.Right;
        CollisionDetection collider;
        char movementStatus = 'd';
        int jumpCount = 0;
        public event EventHandler menu_btn;
        public event Action nextlvl_btn;
        VerticalGhost g1;
        HorizontalGhost g2;
        RandomGhost g3;
        public Level1()
        {
            InitializeComponent();
            game = new Game("Maze1.txt", this, 26, 67);
            collider = new CollisionDetection();
        }

        private void Level1_Load(object sender, EventArgs e)
        {
            g1 = new VerticalGhost(game.getVerticalGhostImage(), game.getCell(22, 55));
            g2 = new HorizontalGhost(game.getHorizontalGhostImage(), game.getCell(16, 14));
            g3 = new RandomGhost(game.getRandomGhostImage(), game.getCell(8, 16));

            game.addGhost(g1);
            game.addGhost(g2);
            game.addGhost(g3);
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            movePlayer();
            moveGhosts();
            moveDown();
            MoveFire();
            game.RemoveFire();
            if (Keyboard.IsKeyPressed(Key.Escape))
            {
                setMenu();
            }
            checkLevel();
            showScore();
        }
        private void checkLevel()
        {
            if (game.player.CurrentCell.nextCell(direct).CurrentGameObject.GameObjectType == GameObjectType.HOLE)
            {
                nextlvl_btn?.Invoke();
                this.Close();
            }
        }
        private void MoveFire()
        {

            foreach (Fire f in game.Fires)
            {
                if (collider.isHMCollideWithBullet(f))
                {
                    HM.Value -= 20;
                    if (HM.Value <= 0)
                    {
                        game.deleteGhost(g2);
                    }
                }
                if (collider.isVMCollideWithBullet(f))
                {
                    VM.Value -= 20;
                    if (VM.Value <= 0)
                    {
                        game.deleteGhost(g1);
                    }
                }
                if (collider.isRMCollideWithBullet(f))
                {
                    RM.Value -= 10;
                    if (RM.Value <= 0)
                    {
                        game.deleteGhost(g3);
                    }
                }
                f.move(f.nextCell());
            }
        }
        private void GhostDelete()
        {

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
            menu_btn?.Invoke(this, e);
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
                    if (player.Value > 0)
                    {
                        player.Value -= 10;
                        if(player.Value == 0)
                        {

                        MessageBox.Show("Game over");
                        Environment.Exit(0);
                        }
                    }
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
            GameCell currentCell = player.CurrentCell;
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                potentialNewCell = player.CurrentCell.nextCell(GameDirection.Left);
                direct = GameDirection.Left;
                movementStatus = 'd';
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                potentialNewCell = player.CurrentCell.nextCell(GameDirection.Right);
                direct = GameDirection.Right;
                movementStatus = 'd';
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                movementStatus = 'u';
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                GameCell NewCell = player.CurrentCell.nextCell(direct);
                Fire f = new Fire(Properties.Resources.bullet, NewCell, direct);
                game.addFire(f);
            }
            if (collider.isPlayerCollideWithCoin(potentialNewCell))
            {
                game.addScorePoints(1);
            }
            currentCell.setGameObject(Game.getBlankGameObject());
            player.move(potentialNewCell);
        }
        private void moveDown()
        {
            Player player = game.player;
            GameCell potentialNewCell = player.CurrentCell;
            GameCell nextCell;
            if (movementStatus == 'd')
            {
                nextCell = player.CurrentCell.nextCell(GameDirection.Down);
                if (nextCell != potentialNewCell)
                {
                    GameCell currentCell = player.CurrentCell;
                    currentCell.setGameObject(Game.getBlankGameObject());
                    player.move(nextCell);
                }

            }
            if (movementStatus == 'u')
            {
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
        }
    }
}
