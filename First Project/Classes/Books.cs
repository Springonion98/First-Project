using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace First_Project.Classes
{
    internal class Books
    {
        //Contact class with properties.
        [PrimaryKey, AutoIncrement]
        //AutoIncrement makes a unike ID
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;    
        public string Auteur { get; set; } = String.Empty;
    }
}
