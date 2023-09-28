using System.Runtime.CompilerServices;

namespace CrossWord_JaPon
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            init();
            
        }

        Bitmap map = new Bitmap(256, 256);
        Graphics graphics;

        bool[,] bools = new bool[10,10];

        private void gameArea_MouseDown(object sender, MouseEventArgs e)
        {
            
            int x = e.X/40;
            x = x * 40+1;
            int y = e.Y / 40;
            y = y * 40;
            int yMax = y + 40;
            Point start = new Point(x, y);
            Point end = new Point(x+38, y);

            Pen pen;
            if (map.GetPixel(x + 1, yMax - 6).R != Color.Black.R) pen = new Pen(Color.Black);
            else pen = new Pen(gameArea.BackColor);

            if (x/40 > 1 && y /40 >2)
            for (y++; y < yMax; y++) 
            {
                start.Y = y;
                end.Y = y;
                     graphics.DrawLine(pen, start, end);
                    
            }
            if (x / 40 > 1 && y / 40 > 2)
            {
                if (map.GetPixel(x + 1, yMax - 6).R != Color.Black.R) bools[(x/40) - 2, (y/40) - 4] = false;
                else bools[(x/40) - 2, (y/40) - 4] = true;
            }
            gameArea.Image = map;
            label1.Text = (x / 40).ToString() + " " + (y/40).ToString();


        }
        private void init() 
        {
            Pen pen = new Pen(Color.Black, 3f);
            map = new Bitmap( gameArea.Width, gameArea.Height);
            graphics= Graphics.FromImage(map);
            Point start = new Point();
            Point end = new Point();
            start.X = 0;
            end.X = gameArea.Width;

            for (int y = 0; y < gameArea.Height; y+= 40) 
            {
                start.Y = y;
                end.Y = y;
                graphics.DrawLine(Pens.Black, start, end);
            }
            

            start.Y=0;
            end.Y=gameArea.Height;

            for (int x = 0; x < gameArea.Width; x+=40) 
            {
                start.X = x;
                end.X = x;
                graphics.DrawLine(Pens.Black, start, end);
            }
            start = new Point(0, 120);
            end = new Point(gameArea.Width,120);
            graphics.DrawLine(pen, start, end);
            start = new Point(80, 0);
            end = new Point(80, gameArea.Height);
            graphics.DrawLine(pen, start, end);
            gameArea.Image = map;
        }


        private void DrawFont() 
        {

        }

        
    }
}

