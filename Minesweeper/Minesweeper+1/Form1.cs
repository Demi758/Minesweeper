using System.Xml.Linq;
using static Minesweeper_1.Form1;
using static System.Formats.Asn1.AsnWriter;

namespace Minesweeper_1
{
    public partial class Form1 : Form
    {
        private int timeElapsed;
        public int score = 0;
        public int difficulty_selected = 0;
        Form2 difficulty_setter = new Form2();
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            difficulty_setter.Show();
            instance = this;
        }

        public void load_map()
        {
            timeElapsed = 0;
            timer1.Start();
            score = 0;
            scorelbl.Text = score.ToString();
            Matrix map = new Matrix(difficulty_selected);
            matrixPanel.Controls.Clear();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    PictureBox tile = new PictureBox();
                    tile.Width = 50;
                    tile.Height = 50;
                    tile.Left = i * 50;
                    tile.Top = j * 50;
                    tile.BorderStyle = BorderStyle.FixedSingle;
                    tile.Image = imageList1.Images[0];
                    tile.SizeMode = PictureBoxSizeMode.StretchImage;
                    tile.Name = "Not Clicked";
                    matrixPanel.Controls.Add(tile);
                    tile.MouseClick += new MouseEventHandler(Tile_Click);

                    if (!map.tiles[i, j].safe)
                    {
                        tile.Tag = "bomb";
                    }
                    else
                    {
                        tile.Tag = map.tiles[i, j].bombs_around.ToString();
                    }
                }
            }
        }

        private void Tile_Click(object sender, MouseEventArgs e)
        {
            DialogResult ans;
            PictureBox clicked_tile = (PictureBox)sender;
            if (e.Button == MouseButtons.Right)
            {
                clicked_tile.Image = imageList1.Images[3];
            }
            else
            {
                
                switch (clicked_tile.Tag.ToString())
                {
                    case ("0"):
                        clicked_tile.Image = imageList1.Images[2];
                        break;
                    case ("1"):
                        clicked_tile.Image = imageList1.Images[4];
                        break;
                    case ("2"):
                        clicked_tile.Image = imageList1.Images[5];
                        break;
                    case ("3"):
                        clicked_tile.Image = imageList1.Images[6];
                        break;
                    case ("4"):
                        clicked_tile.Image = imageList1.Images[7];
                        break;
                    case ("5"):
                        clicked_tile.Image = imageList1.Images[8];
                        break;
                    case ("6"):
                        clicked_tile.Image = imageList1.Images[9];
                        break;
                    case ("7"):
                        clicked_tile.Image = imageList1.Images[10];
                        break;
                    case ("8"):
                        clicked_tile.Image = imageList1.Images[11];
                        break;
                    case ("bomb"):
                        clicked_tile.Image = imageList1.Images[1];
                        timer1.Stop();
                        ans = MessageBox.Show("Try Again?", "You Lost", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ans == DialogResult.Yes)
                        {
                            if (difficulty_setter.IsDisposed)
                            {
                                difficulty_setter = new Form2();
                            }
                            difficulty_setter.Show();
                        }
                        else
                        {
                            Application.Exit();
                        }
                        break;
                }
                if(clicked_tile.Name != "Clicked" && clicked_tile.Tag != "bomb")
                {
                    clicked_tile.Name = "Clicked";
                    score += 10;
                    scorelbl.Text = score.ToString();
                }
            }
        }

        public class Tile
        {
            public bool safe { get; set; }
            public bool clicked { get; set; }
            public int bombs_around { get; set; }

            public Tile()
            {
                safe = true;
                clicked = false;
                bombs_around = 0;
            }
        }

        public class Matrix
        {

            public Tile[,] tiles;

            private int num_bombs;
            public Matrix(int difficulty)
            {
                if (difficulty == 0)
                {
                    this.num_bombs = 10;
                }
                else if (difficulty == 1)
                {
                    this.num_bombs = 20;
                }
                else
                {
                    this.num_bombs = 30;
                }
                tiles = new Tile[10, 10];

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        tiles[i, j] = new Tile();
                    }
                }
                SetMines();
            }
            private void SetMines()
            {
                Random rand = new Random();
                int bombcnt = 0;
                while (bombcnt < num_bombs)
                {
                    int x = rand.Next(10);
                    int y = rand.Next(10);
                    if (tiles[x, y].safe)
                    {
                        tiles[x, y].safe = false;
                        bombcnt++;
                    }
                }

                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tiles[i, j].bombs_around = CountBombs(i, j);
            }

            private int CountBombs(int x, int y)
            {
                int cnt = 0;
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        int row = x + i;
                        int col = y + j;
                        if (row >= 0 && col >= 0 && row < 10 && col < 10)
                        {
                            if (!tiles[row, col].safe)
                            {
                                cnt++;
                            }
                        }
                    }
                }
                return cnt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_map();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            timerlbl.Text = "Time: " + timeElapsed.ToString() + " s";
        }
    }
}
