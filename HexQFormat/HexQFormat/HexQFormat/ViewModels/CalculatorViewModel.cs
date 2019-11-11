using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace HexQFormat.ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {
        public CalculatorViewModel()
        {
            Title = "Hex Calculator";

        }

        public ICommand OpenWebCommand { get; }

        
    }
}