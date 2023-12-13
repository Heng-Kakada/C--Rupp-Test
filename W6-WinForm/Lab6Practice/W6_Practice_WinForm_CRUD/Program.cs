namespace W6_Practice_WinForm_CRUD
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new PersonForm());
        }
    }
}