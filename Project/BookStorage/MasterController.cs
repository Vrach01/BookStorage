using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStorage
{
    class MasterController
    {
        public void OnOpen()
        {

        }
        public void CloseApp()
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
