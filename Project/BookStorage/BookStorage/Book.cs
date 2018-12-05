using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace BookStorage
{
    public class Book
    {
        [PrimaryKey, AutoIncrement, Unique]
        public int Id { get; set; }

        [MaxLength(30), NotNull]
        public String BookName { get; set; }

        [MaxLength(30), NotNull]
        public String Signification { get; set; }

        [NotNull]
        public String Genre { get; set; }

        [NotNull]
        public String Path { get; set; }

        [Ignore]
        public DateTime DataAdd { get; set; }

        public override string ToString()
        {
            return string.Format(
                "  Book - {0}, Signification - {1},Genre - {2}, DataAdd - {3} ",
                 BookName, Signification, Genre, DataAdd.ToString("hh:mm  dd-MM-yyyy")
                );
        }


    }
}
