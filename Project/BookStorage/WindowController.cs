using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookStorage
{
    class WindowController : MasterController
    {
        public void OpenWindow(Window windows)
        {
            windows.ShowDialog();
        }
        public void CloseWindow(Window windows)
        {
            windows.Close();
        }
    }
}
