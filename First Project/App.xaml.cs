using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SQLite;

namespace First_Project
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //database contection
        //
        static string strDatabaseName = "Books.db";
        //make conection with universel folder in my documents
        //the conection wil word on all computers
        static string strFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //this combines the two upper lines, it wil be easier to refrens to.
        public static string strDatabasePath = System.IO.Path.Combine(strFolderPath, strDatabaseName);
    }
}
