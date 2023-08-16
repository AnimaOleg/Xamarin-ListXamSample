using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamSample.Models;

namespace XamSample.ViewModels
{
    public class VMProductDetail : INotifyPropertyChanged
    {
        private Products _product;

        public Products Product
        {
            get => _product;
            set
            {
                _product = value;
                OnPropertyChanged();
            }
        }

        public VMProductDetail(Products selectedProduct)
        {
            Product = selectedProduct;

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
