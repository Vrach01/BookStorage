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

namespace BookStorage
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private static string genre;
        private static DBManager db;
        private  ListBox listBox;
        public AddWindow(DBManager _db, ref ListBox listBox)
        {
            InitializeComponent();
            db = _db;
            this.listBox = listBox;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            
            Close();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            foreach(var item in listBox.Items)
            {
                if(((Book)item).BookName == BookNameBox.Text)
                {
                    var result = MessageBox.Show("Такая книга уже существует!","Warning",MessageBoxButton.OK,MessageBoxImage.Warning);
                    if(result == MessageBoxResult.OK)
                    {
                        return;
                    }
                }
            }
            var Book = new Book();
            Book.Genre = genre;
            Book.DataAdd = DateTime.Now;
            Book.BookName = BookNameBox.Text;
            Book.Signification = SignificationBox.Text;
            db.AddElement(Book);
            listBox.Items.Add(Book);
            Close();
        }

        private void Fantasy_Click(object sender, RoutedEventArgs e)
        {
            genre = Fantasy.Content.ToString();
        }

        private void Historical_Click(object sender, RoutedEventArgs e)
        {
            genre = Historical.Content.ToString();
        }

        private void Philosophy_Click(object sender, RoutedEventArgs e)
        {
            genre = Philosophy.Content.ToString();
        }

        private void Science_fiction_Click(object sender, RoutedEventArgs e)
        {
            genre = Science_fiction.Content.ToString();
        }

        private void Fairy_tale_Click(object sender, RoutedEventArgs e)
        {
            genre = Fairy_tale.Content.ToString();
        }

        private void Science_Click(object sender, RoutedEventArgs e)
        {
            genre = Science.Content.ToString();
        }

        private void Western_Click(object sender, RoutedEventArgs e)
        {
            genre = Western.Content.ToString();
        }
    }
}
