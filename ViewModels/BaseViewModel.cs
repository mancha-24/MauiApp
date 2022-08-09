using System.ComponentModel;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel(Models.Product dataObj)
        {
            Id = int.Parse(dataObj.id);
            Title = dataObj.name;
            Description = dataObj.description;
            Category = dataObj.category;
            SubCategory = dataObj.subcategory;
            ImageUrl = dataObj.image;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public CategoryType Category { get; set; }

        public SubCategoryType SubCategory { get; set; }

        public string ImageUrl { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged is not null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}