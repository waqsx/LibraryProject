using LibraryProject.models;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace LibraryProject.LibraryForms
{
    /// <summary>
    /// Логика взаимодействия для AddAuthor.xaml
    /// </summary>
    public partial class AddAuthor : Window
    {
        public AddAuthor()
        {
            InitializeComponent();





        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            using (LibraryContext context = new())
            {
                string name = author_name.Text;
                string lastname = author_lastname.Text;

                if (author_lastname.Text != null && author_name != null)
                {
                    Author author = new Author(name, lastname);
                    context.Authors.Add(author);
                    context.SaveChanges();

                    MessageBox.Show($"{name + ' ' + lastname} добавлен");
                    author_name.Text = "";
                    author_lastname.Text = "";


                }
                else
                {
                    MessageBox.Show("Проверьте данные");
                }
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }


}
