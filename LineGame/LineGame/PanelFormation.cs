using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LineGame
{
    public partial class PanelFormation : Form
    {
        List<Panel> topPanel = new List<Panel>();
        List<Panel> bottomPanel = new List<Panel>();
        List<Color> colors = new List<Color> { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Pink };

        private List<ColoredLine> lines = new List<ColoredLine>();
        private List<Point> intersectingPoint = new List<Point>();
        private List<MovingObject> movers = new List<MovingObject>();

        private Point startPoint;
        private Point endPoint;
        private bool isDrawing = false;
        private bool panelsPlaced = false;

        private Color currentLineColor = Color.Black;
        private Color startPanelColor = Color.Empty;
        private Panel startPanel = null;

        private Timer gameTimer = new Timer();
        private bool gameOver = false;

        int boxCount;

        public PanelFormation()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            mainPanel.MouseMove += mainPanel_MouseMove;
            mainPanel.Paint += mainPanel_Paint;
            mainPanel.MouseUp += mainPanel_MouseUp;

            gameTimer.Interval = 50;  
            gameTimer.Tick += GameLoop;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            topPanel.Clear();
            bottomPanel.Clear();
            lines.Clear(); 
            intersectingPoint.Clear();

            gameTimer.Stop();
            gameOver = false;
            movers.Clear();
             
            mainPanel.Invalidate();

            Random random = new Random();

            if (!int.TryParse(panelBox.Text, out boxCount) || boxCount > 5 || boxCount <= 0)
            {
                errorProvider1.SetError(panelBox, "Invalid Input (1–5 only)");
                panelBox.Clear();
                return;
            }
            else errorProvider1.Clear();

            int width = 80;
            int height = 80;
            int gap = (mainPanel.ClientSize.Width - (width * boxCount)) / (boxCount + 1);
            int yTop = 0;
            int yBottom = mainPanel.ClientSize.Height - height;

            List<Color> topPanelColour = colors.OrderBy(x => random.Next()).Take(boxCount).ToList();
             
            for (int i = 0; i < boxCount; i++)
            {
                Panel p = new Panel
                {
                    Size = new Size(width, height),
                    Location = new Point(gap + i * (width + gap), yTop),
                    BackColor = topPanelColour[i],
                    Tag = topPanelColour[i]
                };

                p.MouseDown += panel_MouseDown;
                topPanel.Add(p);
                mainPanel.Controls.Add(p);
            }
             
            List<Color> bottomPanelColour = topPanelColour.OrderBy(x => random.Next()).ToList();

            for (int i = 0; i < boxCount; i++)
            {
                Panel p = new Panel
                {
                    Size = new Size(width, height),
                    Location = new Point(gap + i * (width + gap), yBottom),
                    BackColor = bottomPanelColour[i],
                    Tag = bottomPanelColour[i]
                };

                bottomPanel.Add(p);
                mainPanel.Controls.Add(p);
            }

            panelBox.Clear();
            panelsPlaced = true;
        }

        //line drawing
        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
             
            foreach (ColoredLine line in lines)
            {
                using (Pen pen = new Pen(line.LineColor, 5))
                {
                    g.DrawLine(pen, line.Start, line.End);
                }
            }
 
            if (isDrawing)
            {
                using (Pen previewPen = new Pen(currentLineColor, 2))
                {
                    g.DrawLine(previewPen, startPoint, endPoint);
                }
            }
             
            foreach (Point p in intersectingPoint)
            {
                g.FillEllipse(Brushes.Purple, p.X - 6, p.Y - 6, 12, 12);
            }
             
            foreach (var m in movers)
            {
                g.FillEllipse(Brushes.Black, m.Position.X - 7, m.Position.Y - 7, 14, 14);
            }
        }
         
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (!panelsPlaced) return;

            Panel clickedPanel = sender as Panel;
            if (clickedPanel == null) return;

            startPanel = clickedPanel;
            startPanelColor = clickedPanel.BackColor;
            currentLineColor = clickedPanel.BackColor;

            startPoint = new Point(
                clickedPanel.Left + clickedPanel.Width / 2,
                clickedPanel.Top + clickedPanel.Height / 2
            );

            isDrawing = true;
        }
         
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                mainPanel.Invalidate();
            }
        }
          
        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing || startPanel == null) return;

            Panel releasedPanel = topPanel.Concat(bottomPanel).FirstOrDefault(p => p.Bounds.Contains(e.Location));

            if (releasedPanel == null)
            {
                ResetDrawing();
                return;
            }

            Color endPanelColor = (Color)releasedPanel.Tag;

            Point releasedCenter = new Point(
                releasedPanel.Left + releasedPanel.Width / 2,
                releasedPanel.Top + releasedPanel.Height / 2
            );

            if (endPanelColor == startPanelColor)
            {
                var newLine = new ColoredLine(startPoint, releasedCenter, currentLineColor);
                lines.Add(newLine);
                
                CheckLineIntersections();
                
                //add moving obj
                movers.Add(new MovingObject(startPoint, releasedCenter));

                //game start if lines joined
                if (movers.Count == topPanel.Count)
                    gameTimer.Start();
            }
            else
            {
                MessageBox.Show("Colors don’t match!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ResetDrawing();
        }

        private void ResetDrawing()
        {
            isDrawing = false;
            startPanel = null;
            mainPanel.Invalidate();
        }

        //check intersection
        private void CheckLineIntersections()
        {
            intersectingPoint.Clear();

            for (int i = 0; i < lines.Count; i++)
            {
                for (int j = i + 1; j < lines.Count; j++)
                {
                    if (LineIntersect(lines[i].Start, lines[i].End, lines[j].Start, lines[j].End, out Point p))
                        intersectingPoint.Add(p);
                }
            }
        }

        private bool LineIntersect(Point p1, Point p2, Point p3, Point p4, out Point intersection)
        {
            intersection = Point.Empty;

            float A1 = p2.Y - p1.Y;
            float B1 = p1.X - p2.X;
            float C1 = A1 * p1.X + B1 * p1.Y;

            float A2 = p4.Y - p3.Y;
            float B2 = p3.X - p4.X;
            float C2 = A2 * p3.X + B2 * p3.Y;

            float denominator = A1 * B2 - A2 * B1;

            if (Math.Abs(denominator) < 0.00001f)
                return false;

            float intersectX = (B2 * C1 - B1 * C2) / denominator;
            float intersectY = (A1 * C2 - A2 * C1) / denominator;

            intersection = new Point((int)intersectX, (int)intersectY);

            bool onLine1 =
                intersectX >= Math.Min(p1.X, p2.X) &&
                intersectX <= Math.Max(p1.X, p2.X) &&
                intersectY >= Math.Min(p1.Y, p2.Y) &&
                intersectY <= Math.Max(p1.Y, p2.Y);

            bool onLine2 =
                intersectX >= Math.Min(p3.X, p4.X) &&
                intersectX <= Math.Max(p3.X, p4.X) &&
                intersectY >= Math.Min(p3.Y, p4.Y) &&
                intersectY <= Math.Max(p3.Y, p4.Y);

            return onLine1 && onLine2;
        }

        //obj mover
        private void GameLoop(object sender, EventArgs e)
        {
            if (gameOver) return;

            // move objects
            foreach (var m in movers)
                m.Move();

            // collision detection
            for (int i = 0; i < movers.Count; i++)
            {
                for (int j = i + 1; j < movers.Count; j++)
                {
                    float dx = movers[i].Position.X - movers[j].Position.X;
                    float dy = movers[i].Position.Y - movers[j].Position.Y;

                    if (Math.Sqrt(dx * dx + dy * dy) < 15)
                    {
                        gameOver = true;
                        gameTimer.Stop();
                        MessageBox.Show("Collision detected! You lose!");
                        mainPanel.Controls.Clear();
                        lines.Clear();
                        intersectingPoint.Clear();
                        movers.Clear();
                        mainPanel.Invalidate();
                        return;
                    }
                }
            }

            // win check
            if (movers.All(m => m.Reached))
            {
                gameTimer.Stop();
                MessageBox.Show("You win!");
                mainPanel.Controls.Clear();
                lines.Clear();
                intersectingPoint.Clear();
                movers.Clear();
                mainPanel.Invalidate();
            }

            mainPanel.Invalidate();
        }
    }

    
    public class ColoredLine
    {
        public Point Start { get; }
        public Point End { get; }
        public Color LineColor { get; }

        public ColoredLine(Point start, Point end, Color color)
        {
            Start = start;
            End = end;
            LineColor = color;
        }
    }
    

    public class MovingObject
    {
        public PointF Position;
        public PointF Target;
        public float Speed = 3f;
        public bool Reached = false;

        public MovingObject(PointF start, PointF end)
        {
            Position = start;
            Target = end;
        }

        public void Move()
        {
            if (Reached) return;

            float dx = Target.X - Position.X;
            float dy = Target.Y - Position.Y;
            float dist = (float)Math.Sqrt(dx * dx + dy * dy);

            if (dist < Speed)
            {
                Position = Target;
                Reached = true;
                return;
            }

            Position.X += Speed * dx / dist;
            Position.Y += Speed * dy / dist;
        }
    }
}
