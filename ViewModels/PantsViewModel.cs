using System;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    public class PantsViewModel : CollectionBaseViewModel
    {
        public PantsViewModel(Services.ProductService productSvc)
        {
            var drinks = productSvc.GetProducts(CategoryType.Clothing, SubCategoryType.Pants);
            base.Items = new System.Collections.ObjectModel.ObservableCollection<BaseViewModel>();
            foreach (var item in drinks)
            {
                base.Items.Add(new BaseViewModel(item));
            }
        }
    }
}

