using Supermarket.Models;
using Supermarket.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace Supermarket._Repositories
{
    internal class CategoriePresenter
    {
        private ICategorieView view;
        private ICategorieRepository repository;
        private BindingSource categorieBindingSource;
        private IEnumerable<CategorieModel> categorieList;

        public CategoriePresenter(ICategorieView view, ICategorieRepository repository)
        {
            this.categorieBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategorie;
            this.view.AddNewEvent += AddNewCategorie;
            this.view.EditEvent += LoadSelectCategorieToEdit;
            this.view.DeleteEvent += DeleteSelectedCategorie;
            this.view.SaveEvent += SaveCategorie;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategorieListBildingSource(categorieBindingSource);

            LoadAllCategorieList();

            this.view.Show();

        }

        private void LoadAllCategorieList()
        {
            categorieList = repository.GetAll();
            categorieBindingSource.DataSource = categorieList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategorie(object? sender, EventArgs e)
        {
            var categorie = new CategorieModel();
            categorie.Id = Convert.ToInt32(view.CategorieId);
            categorie.Name = view.CategorieName;
            categorie.Observation = view.CategorieObservation;

            try
            {
                new Common.ModelDataValidation().Validate(categorie);
                if (view.IsEdit)
                {
                    repository.Edit(categorie);
                    view.Message = "Categorie edited successfuly";
                }
                else
                {
                    repository.Add(categorie);
                    view.Message = "Categorie added successfuly";
                }
                view.IsSuccesful = true;
                LoadAllCategorieList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.CategorieId = "0";
            view.CategorieName = "";
            view.CategorieObservation = "";
        }

        private void DeleteSelectedCategorie(object? sender, EventArgs e)
        {
            try
            {
                var categorie = (CategorieModel)categorieBindingSource.Current;

                repository.Delete(categorie.Id);
                view.IsSuccesful = true;
                view.Message = "Categorie deleted successfully";
                LoadAllCategorieList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "An error ocurred, could ot delete categorie";
            }
        }

        private void LoadSelectCategorieToEdit(object? sender, EventArgs e)
        {
            var categorie = (CategorieModel)categorieBindingSource.Current;

            view.CategorieId = categorie.Id.ToString();
            view.CategorieName = categorie.Name;
            view.CategorieObservation = categorie.Observation;

            view.IsEdit = true;
        }

        private void AddNewCategorie(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategorie(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categorieList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categorieList = repository.GetAll();
            }
            categorieBindingSource.DataSource = categorieList;
        }
    }
}
