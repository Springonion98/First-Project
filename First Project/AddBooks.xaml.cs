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
using First_Project.Classes;
using SQLite;

namespace First_Project
{
    /// <summary>
    /// Interaction logic for AddBooks.xaml
    /// </summary>
    public partial class AddBooks : Window
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //Connection to class
            Books books = new Books()
            {
                Name = txtName.Text,
                Auteur = txtAuteur.Text
            };
            //Connection to database
            using (SQLiteConnection connection = new SQLiteConnection(App.strDatabasePath))
            {
                connection.CreateTable<Books>();
                connection.Insert(books);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Auteur_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
