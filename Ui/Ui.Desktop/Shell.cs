namespace tomaszbaginski.UbsTask2.Ui.Desktop
{
    public class Shell : IShell
    {
        public Shell(MainWindow window)
        {
            window.Title = "";
        }

        public virtual MainWindow window { get; set; }

        public void Run()
        {
            window.Show();
        }
    }
}
