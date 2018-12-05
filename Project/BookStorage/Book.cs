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

        [Ignore]
        public DateTime DataAdd { get; set; }

        public override string ToString()
        {
            return string.Format(
                " {0} : Book - {1}, Signification - {2},Genre - {3}, DataAdd - {4} ",
                Id, BookName, Signification, Genre, DataAdd.ToString("hh:mm  dd-MM-yyyy")
                );
        }


    }
}
