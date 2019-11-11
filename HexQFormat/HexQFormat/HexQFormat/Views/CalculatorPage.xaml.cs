using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HexQFormat.ViewModels;
using System.Linq;

namespace HexQFormat.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage
    {
        Entry testEntry;
        EntryCell testEntryCell;

        public ObservableCollection<FormatViewModel> formats { get; set; }

        public CalculatorPage()
        {
            InitializeComponent();

            testEntry = new Entry() { Text = "Test" };
            testEntryCell = new EntryCell { Text = "new"};

            formats = new FormatList();

            var items = Enumerable.Range(0, 2);
            ListView listView = new ListView();
            listView.HasUnevenRows = true;
            listView.RowHeight = 5;
            listView.ItemTemplate = new DataTemplate(typeof(FormatCell));
            listView.ItemsSource = formats;

            mainLayout.Children.Add(listView);
        }

        public class FormatList : ObservableCollection<FormatViewModel>
        {
            public FormatList() : base() {
                Add(new FormatViewModel() { Name = "HEX", Value = "0" });
                Add(new FormatViewModel() { Name = "DEC", Value = "0" });
                Add(new FormatViewModel() { Name = "OCT", Value = "0" });
                Add(new FormatViewModel() { Name = "BIN", Value = "0" });
            }
        }

        public class FormatCell : ViewCell
        {
            public static readonly BindableProperty NameProperty = 
                BindableProperty.Create("Name", typeof(String), typeof(FormatViewModel), "Name");

            public static readonly BindableProperty ValueProperty =
                BindableProperty.Create("Value", typeof(String), typeof(FormatViewModel), "Value");

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
                    Padding = new Thickness(10, 0.1, 5, 0.1),
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