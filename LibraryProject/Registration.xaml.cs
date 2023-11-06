using LibraryProject.models;
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
using System.Windows.Shapes;

namespace LibraryProject
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            var userlogin = login.Text;

            SecureString secure1 = newpassword.SecurePassword.Copy();
            SecureString secure2 = newpasswordrepeat.SecurePassword.Copy();

            string temp1 = "";
            string temp2 = "";

            foreach (char c in newpassword.Password)
            {
                temp1 += c;

            }
            
            foreach (char c in newpasswordrepeat.Password)
            {
                temp2 += c;
            }

            string userpassword = temp1;
            string userpassword2 = temp2;
            


            using(LibraryContext context = new LibraryContext())
            {
                if (userlogin != null && userpassword != null && userpassword2 != null)
                {
                    if (userpassword==userpassword2)
                    {
                        User user = new(userlogin,userpassword2);
                        context.Users.Add(user);
                        context.SaveChanges();

                        fpass.Background = new SolidColorBrush(Colors.LightGreen);
                        spass.Background = new SolidColorBrush(Colors.LightGreen);
                        MessageBox.Show("Успешно");
                        this.IsEnabled = false;
                        this.Close();

                    }
                    else
                    {
                        fpass.Background = new SolidColorBrush(Colors.Red);
                        spass.Background = new SolidColorBrush(Colors.Red);
                        MessageBox.Show("Пароли должны совпадать");
                    }
                }
            }
        }
    }
}
