using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocalDB
{
    public partial class MainPage : ContentPage
    {
        SqliteConnection _dbcon;
        public MainPage()
        {
            InitializeComponent();
            LocalDB();
        }
        public void LocalDB()
        {
            int i = 0;
            try
            {
                while (i==0)
                {
                    //var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    _dbcon = new SqliteConnection(@"Data Source = db.db3; Mode=ReadWriteCreate; Password = password");        ///
                    _dbcon.Open();
                    i++;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}