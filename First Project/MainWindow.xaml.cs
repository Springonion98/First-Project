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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SQLite;
using First_Project.Classes;


namespace First_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Books> books;
        public MainWindow()
        {
            InitializeComponent();
            //Object contacts to new list made from class Contact
            books = new List<Books>();
            //Opening & refreshing database
            ReadDatabase();
        }

        private void boookList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //SelectionChanged event that opens ContactDetailsWindow
            Books selectedBooks = (Books)BooksList.SelectedItem;
            //Each time an item is selected, show the ContactDetailsWindow of that item (item = contact)
            if (selectedBooks != null)
            {
                ChangeBooks changeBooks = new ChangeBooks();
                changeBooks.ShowDialog(); //Code awaits interaction
                ReadDatabase(); //Refresh database in ListView element
            }

        }

        void ReadDatabase()
        {
            //Connect and read from database
            using (SQLiteConnection conn = new SQLiteConnection(App.strDatabasePath)) 
            {
                conn.CreateTable<Books>();
                books = (conn.Table<Books>().ToList());
            }
            //Show contacts in listview element
            if (books != null)
            {
                booksList.ItemsSource = books;
            }
        }

        private void add_new_book_Click(object sender, RoutedEventArgs e)
        {
            //Button opens AddBooks window
            AddBooks addbooks = new AddBooks();
            addbooks.Show();
        }
    }
}

