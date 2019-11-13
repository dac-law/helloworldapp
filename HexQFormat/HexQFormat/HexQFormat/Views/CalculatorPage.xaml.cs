using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HexQFormat.ViewModels;
using System.Linq;

using HexQFormat.Models;

namespace HexQFormat.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage
    {
        Entry testEntry;
        EntryCell testEntryCell;

        public ObservableCollection<FormatResultViewModel> formats { get; set; }

        public CalculatorPage()
        {
            InitializeComponent();

            resultLabel.Text = "0";

            testEntry = new Entry() { Text = "Test" };
            testEntryCell = new EntryCell { Text = "new"};

            formats = new FormatList();

            var items = Enumerable.Range(0, 2);
            ListView listView = new ListView();
            listView.HasUnevenRows = true;
            listView.RowHeight = 5;
            listView.ItemTemplate = new DataTemplate(typeof(FormatCell));
            listView.ItemsSource = formats;

            CalculatorResult result = new CalculatorResult()
            {
                IsValid = true,
                Result = 25
            };
            resultLabel.Text = new IntResult().GetFormatted(result.Result);

            mainLayout.Children.Add(listView);
        }

        public class FormatList : ObservableCollection<FormatResultViewModel>
        {
            public FormatList() : base() {
                Add(new FormatResultViewModel() { Name = "HEX", Value = "0" });
                Add(new FormatResultViewModel() { Name = "DEC", Value = "0" });
                Add(new FormatResultViewModel() { Name = "OCT", Value = "0" });
                Add(new FormatResultViewModel() { Name = "BIN", Value = "0" });
            }
        }

        public class FormatCell : ViewCell
        {
            public static readonly BindableProperty NameProperty = 
                BindableProperty.Create("Name", typeof(String), typeof(FormatResultViewModel), "Name");

            public static readonly BindableProperty ValueProperty =
                BindableProperty.Create("Value", typeof(String), typeof(FormatResultViewModel), "Value");

            public string Value
            {
                get { return (string)GetValue(ValueProperty); }
                set { SetValue(ValueProperty, value); }
            }

            public string Name
            {
                get { return (string)GetValue(NameProperty); }
                set { SetValue(NameProperty, value); }
            }

            private Label nameLabel, valueLabel;

            public FormatCell()
            {
                nameLabel = new Label();
                valueLabel = new Label();

                nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));
                valueLabel.SetBinding(Label.TextProperty, new Binding("Value"));

                var stackLayout = new StackLayout
                {
                    Padding = new Thickness(10, 0, 5, 0),
                    Children = {
                        nameLabel,
                        valueLabel
                    }, 
                    Orientation = StackOrientation.Horizontal
                };

                View = stackLayout;
            }

        }

    }
}