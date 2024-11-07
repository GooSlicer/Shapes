namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Brush? brush;
        readonly object locker = new();
        void Painter1()
        {
            brush = Brushes.Black;
            lock (locker)
            {
                Graphics graphics = CreateGraphics();
                graphics.FillEllipse(brush, 0, 0, 20, 20);
                graphics.Dispose();
            }
        }
        void Painter2()
        {
            brush = Brushes.White;
            lock (locker)
            {
                Graphics graphics = CreateGraphics();
                graphics.FillEllipse(brush, 20, 20, 100, 100);
                graphics.Dispose();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new(Painter1);
            Thread thread2 = new(Painter2);
            thread1.Start();
            thread2.Start();
        }
    }
}