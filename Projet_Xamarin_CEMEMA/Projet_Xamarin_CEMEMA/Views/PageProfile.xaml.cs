using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projet_Xamarin_CEMEMA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageProfile : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public PageProfile()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "More informations",
                "List Event Created",
                "List Event Participated"
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            if (e.Item.ToString() == "List Event Created")
            {
                var newPage = new PageListEventsCreated();
                await Navigation.PushAsync(newPage);
            }
            else if (e.Item.ToString() == "List Event Participated")
            {
                var newPage = new PageListEventsParticipated();
                await Navigation.PushAsync(newPage);
            }

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
