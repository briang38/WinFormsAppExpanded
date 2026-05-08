namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Show splash screen first
            SplashScreen1 splash = new SplashScreen1();
            splash.Show();
            splash.Refresh();

            // Wait 3 seconds
            System.Threading.Thread.Sleep(3000);

            // Close splash screen
            splash.Close();

            // Launch main form
            Application.Run(new BillingForm());
        }
    }
}