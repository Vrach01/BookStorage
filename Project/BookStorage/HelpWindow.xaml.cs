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
    /// Логика взаимодействия для HelpWindow.xaml
    /// </summary>
    public partial class HelpWindow : Window
    {
        public HelpWindow()
        {
            InitializeComponent();
            string info = "\n\t\t\tГайд по работе программы\nДля того чтобы добавить книгу в каталог, нажмите кнопку <<Add...>>. " +
                "После этого\n появится окно добавления книги, где вы можете выбрать жанр книги, написать её\n название, а также " +
                "оставить свою подпись(по желанию). После этого нажмите <<OK>>, чтобы книга добавилась. <<Cancel>> - отмена.\n\n" +
                "Для удаления книги выберите нужную книгу из списка и нажмите на неё левой\n кнопкой мыши, после чего нажмите кнопку" +
                " <<Delete>>. При запросе на удаление\n нажмите <<OK>> для удаления, <<Cancel>> - для отмены.\n\n" +
                "Для поиска книг в каталоге выберите критерии поиска(слева в главном окне), а также\n введите название нужной книги" +
                "(в правом верхнем углу), после чего нажмите кнопку\n <<Search>>.";
            Info.Content = info;
        }
    }
}
