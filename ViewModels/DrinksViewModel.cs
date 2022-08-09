using System;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    public class DrinksViewModel : CollectionBaseViewModel
    {
        public DrinksViewModel(Services.ProductService productSvc)
        {
            var drinks = productSvc.GetProducts(CategoryType.Supplements, SubCategoryType.Drinks);
            base.Items = new System.Collections.ObjectModel.ObservableCollection<BaseViewModel>();
            foreach (var item in drinks)
            {
                base.Items.Add(new BaseViewModel(item));
            }
        }
    }
}

