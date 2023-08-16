using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamSample.Models;
using XamSample.ViewModels;

namespace XamSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewProducts : ContentPage
    {
        VMProducts vm;
        public ViewProducts()
        {
            InitializeComponent();
            vm = new VMProducts();
            this.BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            if (lstProducts.SelectedItem != null)
                lstProducts.SelectedItem = null;
        }
        private async void LstProducts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Console.WriteLine("LstProducts_ItemSelected");
            try
            {
                Console.WriteLine("list OK");
                if (lstProducts.SelectedItem != null)
                {
                    Products products = (Products)e.SelectedItem;
                    Console.WriteLine("INDICE: " + e.SelectedItemIndex);
                    if (products != null && !string.IsNullOrWhiteSpace(products.ProductName) )
                    {
                        Console.WriteLine("ENTRA");
                        await Navigation.PushAsync(new ViewProductDetails(vm));
                    }
                    else
                        Console.WriteLine("NO ENTRA");

                }
                else
                {
                    Console.WriteLine("list NULL");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" +ex.Message);
            }
        }
    }
}