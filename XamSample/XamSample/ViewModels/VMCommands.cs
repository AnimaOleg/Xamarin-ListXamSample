using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace XamSample.ViewModels
{
    public class VMCommands : INotifyPropertyChanged
    {
        private string _number { get; set; }
        public string number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged();
            }
        }

        public Command btnClick { get; set; }

        public VMCommands()
        {
            number = "5";
            btnClick = new Command<string>(ButtonClick);
            var t = new Command<string>(ButtonClick);
        }

        public void ButtonClick(string value)
        {
            try
            {

                number = (int.Parse(number) + int.Parse(value)).ToString();
                
            }
            catch (Exception ex)
            {

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
