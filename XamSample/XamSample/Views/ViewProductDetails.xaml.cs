
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamSample.ViewModels;

namespace XamSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewProductDetails : ContentPage
    {

        public ViewProductDetails(VMProducts products)
        {
            InitializeComponent();

            if (products != null && products.SelectedProduct != null)
            {
                this.BindingContext = products;
            }
        }
    }
}