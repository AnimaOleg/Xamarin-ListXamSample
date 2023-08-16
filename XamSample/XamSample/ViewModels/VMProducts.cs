using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamSample.Models;

namespace XamSample.ViewModels
{
    public class VMProducts : INotifyPropertyChanged
    {
        private ObservableCollection<Products> _obProducts;
        public ObservableCollection<Products> ObProducts
        {
            get => _obProducts;
            set { _obProducts = value; OnPropertyChanged(); }
        }

        private Products _selectedProduct;

        public Products SelectedProduct
        {
            get => _selectedProduct;
            set {
                _selectedProduct = value;
                OnPropertyChanged();
            }
        }

        public VMProducts()
        {
            AddProducts();

        }

        public void AddProducts()
        {
            try
            {
                ObProducts = new ObservableCollection<Products>();
                ObProducts.Add(new Products
                {
                    ProductImage = "https://images-na.ssl-images-amazon.com/images/I/813y2%2BdPUOL._AC_SL1500_.jpg",
                    ProductName = "Samsung Note 20 5G Ultra",
                    ProductPrice = "$1099",
                    ProductCompany = "Samsung",
                    ProductRating = "4.5"
                });

                ObProducts.Add(new Products
                {
                    ProductImage = "https://m.media-amazon.com/images/I/71sNNCTfMuL._FMwebp__.jpg",
                    ProductName = "Apple iPhone 12 mini",
                    ProductPrice = "$699",
                    ProductCompany = "Apple",
                    ProductRating = "4.6"
                });

                ObProducts.Add(new Products
                {
                    ProductImage = "https://images-na.ssl-images-amazon.com/images/I/61v0enHOXpL._AC_SL1500_.jpg",
                    ProductName = "Google Pixel 2 64 GB",
                    ProductPrice = "$117",
                    ProductCompany = "Google",
                    ProductRating = "3.8"
                });

                ObProducts.Add(new Products
                {
                    ProductImage = "https://images-na.ssl-images-amazon.com/images/I/71MHTD3uL4L._SL1500_.jpg",
                    ProductName = "iPhone 12 Pro Max",
                    ProductPrice = "$1200",
                    ProductCompany = "Apple",
                    ProductRating = "4.0"
                });

                ObProducts.Add(new Products
                {
                    ProductImage = "https://images-na.ssl-images-amazon.com/images/I/71OYLm6srFL._SL1500_.jpg",
                    ProductName = "Samsung Galaxy S20 FE",
                    ProductPrice = "$600",
                    ProductCompany = "Samsung",
                    ProductRating = "4.1"
                });



                ObProducts.Add(new Products
                {
                    ProductImage = "https://images-na.ssl-images-amazon.com/images/I/410mmBW-AYL._AC_.jpg",
                    ProductName = "OnePlus 8 Pro 5G",
                    ProductPrice = "$924",
                    ProductCompany = "OnePlus",
                    ProductRating = "4.7"
                });

                ObProducts.Add(new Products
                {
                    ProductImage = "https://images-na.ssl-images-amazon.com/images/I/71valQo5u5L._AC_SL1500_.jpg",
                    ProductName = "Samsung Galaxy A01",
                    ProductPrice = "$121.76",
                    ProductCompany = "Samsung",
                    ProductRating = "4.1"
                });

                ObProducts.Add(new Products
                {
                    ProductImage = "https://images-na.ssl-images-amazon.com/images/I/61sLvszoETL._AC_SL1500_.jpg",
                    ProductName = "Nokia 2.4 Android 10",
                    ProductPrice = "$1099",
                    ProductCompany = "Nokia",
                    ProductRating = "3.5"
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepcion: " + ex.Message);
            }
        }

        #region INotifyChangedProperties
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {

            /*if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }*/
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion INotifyChangedProperties

    }
}
