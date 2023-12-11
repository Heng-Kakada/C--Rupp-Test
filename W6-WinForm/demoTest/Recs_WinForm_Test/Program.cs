using Rectangle = Recs_WinForm_Test.models.Rectangle;

namespace Recs_WinForm_Test
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            InitRectangles();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static List<Rectangle> Recs => _recs;
        private static List<Rectangle> _recs = new();
        

        private static void InitRectangles()
        {
            (new List<Rectangle> {
                Rectangle.CreateInstance(5, 8),
                Rectangle.CreateInstance(6, 8),
                Rectangle.CreateInstance(3, 7),
                Rectangle.CreateInstance(2, 12),
                Rectangle.CreateInstance(4, 9),
            }).ForEach(rect => { _recs.Add(rect); });
        }


    }
}