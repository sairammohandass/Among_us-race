namespace firstgame
{
    public partial class Form1 : Form
    {

        int amongusSpeed = 8;
        int gravity = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void superman_Click(object sender, EventArgs e)
        {

        }

        private void gametimerevent(object sender, EventArgs e)
        {
            player.Top += gravity;
            lane1.Left -= amongusSpeed;
            lane2.Left -= amongusSpeed;
            lane3.Left -= amongusSpeed;
            lane4.Left -= amongusSpeed;
            scoretext.Text = "score: " + score;

            if (lane4.Left < -150)
            {
                lane4.Left = 850;
                score++;
            }
            if (lane3.Left < -250)
            {
                lane3.Left = 960;
                score++;
            }
            if (lane2.Left < -150)
            {
                lane2.Left = 600;
                score++;
            }
            if (lane1.Left < -180)
            {
                lane1.Left = 900;
                score++;
            }
            if (player.Bounds.IntersectsWith(lane1.Bounds) ||
                player.Bounds.IntersectsWith(lane2.Bounds) ||
                player.Bounds.IntersectsWith(lane3.Bounds) ||
                player.Bounds.IntersectsWith(lane4.Bounds)||
                player.Bounds.IntersectsWith(ground.Bounds)
                )
            {
                endGame();
            }
                

        }   

        private void gamekeydown(object sender, KeyEventArgs e)
        {    

            if(e.KeyCode==Keys.Space)
            {
                gravity = -8;
            }

        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 7;
            }

        }
        private void endGame()
        {
        gametimer.Stop();
            scoretext.Text += "        OUT   tu da venna!!!";
        }
    }
}