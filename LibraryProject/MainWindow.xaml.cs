using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibraryProject.models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;


namespace LibraryProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LibraryContext db;

        public MainWindow()
        {
           InitializeComponent();

            db = new LibraryContext();

        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {

            var userlogin = user_login.Text;
            SecureString pass = user_password.SecurePassword.Copy();
            string str = "";
            foreach (char c in user_password.Password)
            {
                str += c;
            }
            string userpassword = str;

            using (LibraryContext context = new())
            {
                bool userfound = context.Users.Any(user => user.Login == userlogin && user.Password == userpassword);

                if (userfound)
                {
                    GiveAccess();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User not found");

                }

            }


        }


        public void GiveAccess()
        {
            LibraryMain library = new();
            library.Show();
          
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();

            if (!registration.IsActive)
            {
                this.Show();
            }

        }
    }
}
