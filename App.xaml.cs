using System;
using System.IO;

namespace Medical_Assistance
{
    public partial class App : Application
    {
        private static Services.DatabaseHelper _database;

        public static Services.DatabaseHelper Database
        {
            get
            {
                if (_database == null)
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "medical.db3");
                    _database = new Services.DatabaseHelper(path);
                }
                return _database;
            }
        }

        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
