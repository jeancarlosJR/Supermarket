using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Models;
using Supermarket.Views;
using Supermarket._Repositories;

namespace Supermarket.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowProductView += ShowProductView;
            this.mainView.ShowProviderView += ShowProductView;
            this.mainView.ShowCategorieView += ShowCategorieView;


        }

        private void ShowPayModeView(object? sender , EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository= new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }
        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }
        private void ShowProviderView(object? sender, EventArgs e)
        {
            IProviderView view = ProviderView.GetInstance((MainView)mainView);
            IProviderRepository repository = new ProviderRepository(sqlConnectionString);
            new ProviderPresenter(view, repository);
        }

        private void ShowCategorieView(object? sender, EventArgs e)
        {
            ICategorieView view = CategorieView.GetInstance((MainView)mainView);
            ICategorieRepository repository = new CategorieRepository(sqlConnectionString);
            new CategoriePresenter(view, repository);
        }












    }
}
