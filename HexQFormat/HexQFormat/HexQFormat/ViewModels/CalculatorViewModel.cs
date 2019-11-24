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

        // placeholders 
        public Boolean isHexMode()
        {
            return false;
        }

        public Boolean isDecMode()
        {
            return false;
        }

        public Boolean isOctMode()
        {
            return false;
        }

        public Boolean isBinMode()
        {
            return false;
        }
    }
}