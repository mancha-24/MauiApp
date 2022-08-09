﻿using System;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    public class VitaminsViewModel : CollectionBaseViewModel
    {
        public VitaminsViewModel(Services.ProductService productSvc)
        {
            var drinks = productSvc.GetProducts(CategoryType.Supplements, SubCategoryType.Vitamins);
            base.Items = new System.Collections.ObjectModel.ObservableCollection<BaseViewModel>();
            foreach (var item in drinks)
            {
                base.Items.Add(new BaseViewModel(item));
            }
        }
    }
}

