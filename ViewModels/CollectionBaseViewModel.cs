using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiApp1.ViewModels
{
    public class CollectionBaseViewModel
    {
        public CollectionBaseViewModel()
        {

            //Items = new ObservableCollection<T>();
            ItemSelectedCommand = new Command(async (item) =>
            {
                try
                {
                    BaseViewModel model = (BaseViewModel)item;

                    await AppShell.Current.GoToAsync("Detail",
                        new Dictionary<string, object>
                        {
                        {"Item", model}
                        });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                
            });
        }
        public ObservableCollection<BaseViewModel> Items { get; set; }
        public ICommand ItemSelectedCommand { get; set; }
    }
}