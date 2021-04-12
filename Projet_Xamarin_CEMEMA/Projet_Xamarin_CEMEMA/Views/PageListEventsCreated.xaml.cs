using System.Collections.ObjectModel;
using Projet_Xamarin_CEMEMA.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projet_Xamarin_CEMEMA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListEventsCreated : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        ListEvent listEvent = new ListEvent();

        public PageListEventsCreated()
        {
            InitializeComponent();

            foreach(EvenementModel evenement in listEvent.evenements)
            {
                Items.Add(evenement.Name);
            }

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            bool answer = await DisplayAlert(e.Item.ToString(), "What do you want?", "Modify", "Remove");

            if (answer == false)
            {
                listEvent.RemoveEvent(e.Item.ToString());
            }
            else
            {
                // Get value of each entry in the model
                var evenement = listEvent.FindEvent(e.Item.ToString());

                // Go to the PageEnventInfo
                var newPage = new PageEventInfo(evenement);
                await Navigation.PushAsync(newPage);
            }

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
