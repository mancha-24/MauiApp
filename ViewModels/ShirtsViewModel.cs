using System;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    public class ShirtsViewModel : CollectionBaseViewModel
    {
        public ShirtsViewModel(Services.ProductService productSvc)
        {
            var drinks = productSvc.GetProducts(CategoryType.Clothing, SubCategoryType.Shirts);
            base.Items = new System.Collections.ObjectModel.ObservableCollection<BaseViewModel>();
            foreach (var item in drinks)
            {
                base.Items.Add(new BaseViewModel(item));
            }
        }
    }
}

