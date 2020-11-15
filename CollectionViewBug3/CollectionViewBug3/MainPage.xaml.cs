using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewBug3
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Grouping<string, string>> Items { get; set; } = new ObservableCollection<Grouping<string, string>>()
        {
            new Grouping<string, string>("Grope 1",new List<string>())
        };

        public ICommand AddRow { get; }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            AddRow = new Command<Grouping<string, string>>((arg) =>
           {
               arg.Add($"{arg.Count + 1}");
           });
        }
    }
}