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
        Label[] lables = new Label[33];
        byte[,] cells = new byte[10,10];

        bool[,] cellsWin = new bool[10,10];

        private void gameArea_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X/40;
            x = x * 40+1;
            int y = e.Y / 40;
            y = y * 40;
            int yMax = y + 40;
            Point start = new Point(x, y);
            Point end = new Point(x+38, y);
            int x_coordinate = (x / 40) - 2;
            int y_coordinate = (y / 40) - 3;
            
            if (x / 40 > 1 && y / 40 > 2  && cells[x_coordinate, y_coordinate] > 3) cells[x_coordinate, y_coordinate] = 0;
            Pen pen;
            if (x / 40 > 1 && y / 40 > 2 && cells[x_coordinate, y_coordinate] == 0 ) pen = new Pen(Color.Black);
            else pen = new Pen(gameArea.BackColor);

            if (x/40 > 1 && y /40 >2)
            for (int i = y+1; i < yMax; i++) 
            {
                start.Y = i;
                end.Y = i;
                graphics.DrawLine(pen, start, end);   
            }

            if (x / 40 > 1 && y / 40 > 2 && cells[x_coordinate, y_coordinate] == 1) 
            {
                start.Y = y;
                start.X = x;
                end = start;
                end.Y += 40;
                end.X += 40;
                graphics.DrawLine(new Pen(Color.Black, 2f), start, end);
                end.Y -= 40;
                start.Y += 40;
                graphics.DrawLine(new Pen(Color.Black, 2f), start, end);
            }
            if (x / 40 > 1 && y / 40 > 2) cells[x_coordinate, y_coordinate]++;
            gameArea.Image = map;
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
            LabelGenerator();
            PushCellsWin(0, 10, 9);
            PushCellsWin(0, 10, 8);
            PushCellsWin(4, 6, 7);
            PushCellsWin(3, 7, 6);
            PushCellsWin(1, 8, 5); 
            PushCellsWin(3, 8, 4); cellsWin[0, 4] = true;
            PushCellsWin(3, 10, 3); cellsWin[0, 3] = true;
            PushCellsWin(0, 3, 2); PushCellsWin(4, 7, 2);
            cellsWin[7, 0] = true; cellsWin[7, 1] = true; cellsWin[6, 1] = true;
        }

        int[] lablesPositions = new int[33] { 3003, 3002, 4003, 4002, 4001, 5003, 5002, 6003, 6002, 7003, 8003, 9003, 9002, 10003, 10002, 10001, 11003, 11002, 12003, 12002, 1006, 1007, 1008, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 20013};


        string[] lablesTexts = new string[33] { "2", "3", "2", "1", "1", "2", "4", "2", "4", "8", "8", "2", "6", "2", "3", "2", "2", "1", "2", "1", "3", "1", "1", "1", "2", "3", "8", "6", "7", "4", "2", "100", "100"};



        private void LabelGenerator() 
        {
            //lablesPositions = 
            //lablesTexts = 
            int x = 0;
            int y = 0;

            for (int i = 0; i < 33; i++) 
            {
                lables[i] = new Label();
                x = lablesPositions[i] / 1000;
                y = lablesPositions[i] % 1000;
                lables[i].Location = PositionToPoint(x, y);
                lables[i].Text = lablesTexts[i];
                lables[i].TabIndex = i + 1;
                if (y < 10) lables[i].Size = new Size(10, 15);
                else lables[i].Size = new Size(20,15);
                gameArea.Controls.Add(lables[i]);
                
            }
            
        }



        private Point PositionToPoint(int x_pos, int y_pos) 
        {
            int x = x_pos*40, y = y_pos*40;
            x -= 20; y -= 20;


            return new Point(x,y);
        }



        private void buttonClear_Click(object sender, EventArgs e)
        {
            init();
            cells = new byte[10,10];
        }

        private void buttonCheckWin_Click(object sender, EventArgs e)
        {
            if (CheckWin()) label1.Text = "You Won!";
            else label1.Text = "Not Won";
        }

        private bool CheckWin()
        {
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (cellsWin[i,j]) if (cells[i,j] != 1) return false;
                }
            }
            return true;
        }
        private void PushCellsWin(int x_start,int x_end, int y) 
        {
            for (int i = x_start; i < x_end; i++) 
            {
                cellsWin[i, y] = true;
            }
        }

    }
}

