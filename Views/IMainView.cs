using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Views
{
    internal interface IMainView
    {
        event EventHandler ShowPayModeView;
        event EventHandler ShowProductView;
        event EventHandler ShowProviderView;
        event EventHandler ShowCustomerView;
        event EventHandler ShowCategorieView;

        // Los demas
    }
}
