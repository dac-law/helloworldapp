using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HexQFormat.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        Entry testEntry;
        EntryCell testEntryCell;

        public AboutPage()
        {
            InitializeComponent();

            testEntry = new Entry() { Text = "Test" };
            testEntryCell = new EntryCell { Text = "new"};

            Button button = new Button() { Text = "new button"};
            
        }

    }
}