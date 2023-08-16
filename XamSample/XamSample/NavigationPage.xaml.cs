using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamSample
{
    public partial class NavigationPage : ContentPage
    {
        public NavigationPage()
        {
            InitializeComponent();

            new Views.ViewProducts();

        }
    }
}
