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
    /// Логика взаимодействия для AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        private string info;

        public AboutWindow()
        {
            InitializeComponent();
            info = "Данный проект принадежит студенту БГУИР факультета КСиС \nспециальности ВМСиС группы 650501 Польгую Никите.\n" +
                "\n\t\tВсе права защищены © 2018 BSUIR Inc.";
            Info.Content = info;
        }
    }
}
