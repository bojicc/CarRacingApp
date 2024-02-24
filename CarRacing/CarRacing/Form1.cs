namespace CarRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(15);
            Enemy(15);
            GameOver();
            Coins(7);
            CoinsCollection();
            
        }

        void MoveLine(int speed)
        {
            if(pictureBox1.Top >= 500)
            {
                pictureBox1.Top = -50;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if(pictureBox2.Top >= 500)
            {
                pictureBox2.Top = -50;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if(pictureBox3.Top >= 500)
            {
                pictureBox3.Top = -50;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = -50;
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left) 
            {
                if(car.Left > 16)
                {
                    car.Left += -8;
                }
            }
            if(e.KeyCode == Keys.Right)
            {
                if(car.Right < 368) 
                {
                    car.Left += 8;
                }
            }
        }

        Random r = new Random();
        void Coins(int speed)
        {
            if(coin1.Top >= 500)
            {
                var x = r.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }
            if (coin2.Top >= 500)
            {
                var x = r.Next(100, 300);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top >= 500)
            {
                var x = r.Next(0, 400);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
        }

        void CoinsCollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                int temp = Convert.ToInt32(lblCoins.Text);
                temp++;
                lblCoins.Text = temp.ToString();
                coin1.Location = new Point(0, 200);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                int temp = Convert.ToInt32(lblCoins.Text);
                temp++;
                lblCoins.Text = temp.ToString();
                coin2.Location = new Point(100, 300);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                int temp = Convert.ToInt32(lblCoins.Text);
                temp++;
                lblCoins.Text = temp.ToString();
                coin3.Location = new Point(200, 400);
            }
        }

        void Enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                var x = r.Next(0, 200);
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }
            if (enemy2.Top >= 500)
            {
                var x = r.Next(200, 400);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }
            if (enemy3.Top >= 500)
            {
                var x = r.Next(0, 400);
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }
        }

        void GameOver()
        {
            if(car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
            }
        }
    }
}