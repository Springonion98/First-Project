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
using SQLite;
using First_Project.Classes;

namespace First_Project
{
    /// <summary>
    /// Interaction logic for ChangeBooks.xaml
    /// </summary>
    public partial class ChangeBooks : Window
    {
        Books books;
        public ChangeBooks(Books books)
        {
            InitializeComponent();

            //Loading contact in Window
            this.books = books;
            txtName.Text = books.Name;
            txtAuteur.Text = books.Auteur;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //Update existing books
            books.Name = txtName.Text;
            books.Auteur = txtAuteur.Text;


            //Connection to database
            using SQLiteConnection connection = new SQLiteConnection(App.strDatabasePath);
            {
                connection.CreateTable<Books>();
                connection.Update(books);
            }
            Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //Deleting an existing contact from database.
            using SQLiteConnection conn = new SQLiteConnection(App.strDatabasePath);
            {
                conn.CreateTable<Books>();
                conn.Delete(books);
            }
            Close();
        }



        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }









        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtAuteur_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
