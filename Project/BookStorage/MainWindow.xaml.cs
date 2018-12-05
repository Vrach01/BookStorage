using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static DBManager db;
        public MainWindow()
        {
            InitializeComponent();
            db = new DBManager();
            var DataBase = db.CreateDB("File.db", false);
            var books = db.GetData();
            foreach(var book in books)
            {
                if (book.Signification != String.Empty) UserNameBox.Items.Add(book.Signification);
                BookList.Items.Add(book);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddWindow(db, ref BookList);
            addWindow.Owner = this;
            addWindow.ShowDialog();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            var helpWindow = new HelpWindow();
            helpWindow.Owner = this;
            helpWindow.ShowDialog();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            var aboutWindow = new AboutWindow();
            aboutWindow.Owner = this;
            aboutWindow.ShowDialog();
        }

        private void BookList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BookList.SelectedItem != null)
            {
                DeleteButton.IsEnabled = true;
            }
            else DeleteButton.IsEnabled = false;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            BookList.Items.Clear();
            var books = db.GetData();
            if (SearchLine.Text == String.Empty)
            {
                var year = new TimeSpan(365, 0, 0, 0);
                var month = new TimeSpan(30, 0, 0, 0);
                var week = new TimeSpan(7, 0, 0, 0);
                var day = new TimeSpan(1, 0, 0, 0);
                TimeSpan zero = TimeSpan.Zero;

                foreach (var book in books)
                {
                    if (TimeBox.SelectedValue !=null)
                    {
                        var strTime = ((ComboBoxItem)TimeBox.SelectedValue).Content.ToString();
                        switch (strTime)
                        {
                            case "a day":
                                if (DateTime.Now.Subtract(book.DataAdd) > day.Subtract(zero)) continue;
                                break;

                            case "a week":
                                if (DateTime.Now.Subtract(book.DataAdd) > week.Subtract(zero)) continue;
                                break;

                            case "a month":
                                if (DateTime.Now.Subtract(book.DataAdd) > month.Subtract(zero)) continue;
                                break;

                            case "a year":
                                if (DateTime.Now.Subtract(book.DataAdd) > year.Subtract(zero)) continue;
                                break;

                            default:

                                break;

                        }
                    }
                    if ( GenreBox.SelectedValue == null ||
                        ((ComboBoxItem)GenreBox.SelectedValue).Content.ToString() == "None" ||
                        ((ComboBoxItem)GenreBox.SelectedValue).Content.ToString() == book.Genre)
                    {
                        if( UserNameBox.SelectedValue == null || 
                            UserNameBox.SelectedValue.ToString() == "None" ||
                            UserNameBox.SelectedValue.ToString() == book.Signification)
                            BookList.Items.Add(book);
                    }
                    
                }
            }
            else
            {
                var stringCheck = SearchLine.Text;
                bool match;
                foreach (var book in books)
                {
                    match = true;
                    for(var i = 0; i < stringCheck.Length; i++)
                    {
                        if (stringCheck[i] != book.BookName[i])
                        {
                            match = false;
                            i = stringCheck.Length;
                        }
                    }
                    if(match == true) BookList.Items.Add(book);
                }
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            BookList.UnselectAll();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var message = "Удалить книгу " + ((Book)BookList.SelectedValue).BookName + "?";
            var caption = "Delete";
            MessageBoxButton buttons = MessageBoxButton.YesNo;

            var result = MessageBox.Show(message, caption, buttons, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                db.DeleteElement(((Book)BookList.SelectedItem));
                    BookList.Items.Remove(BookList.SelectedItem);

            }
            else if(result == MessageBoxResult.No)
            {
                
            }
        }
    }
}
