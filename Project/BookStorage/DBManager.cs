using System;
using System.Collections.Generic;
using SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStorage
{
    public class DBManager
    {
        public static SQLiteConnection db { get; set; }
        public DBManager(){
            
        }
        public SQLiteConnection CreateDB(string filename, bool parse)
        {
            db = new SQLiteConnection(filename, parse); 
            if(db.Table<Book>().Count() != 0) db.CreateTable<Book>();
            return db;
        }
        public void AddElement(Book elem)
        {
            db.Insert(elem);
        }
        public void DeleteElement(Book elem)
        {
            db.Delete(elem);
        }
        public TableQuery<Book> GetData()
        {
            var BookCatalogy = db.Table<Book>();
            return BookCatalogy;
        }

    }
}
