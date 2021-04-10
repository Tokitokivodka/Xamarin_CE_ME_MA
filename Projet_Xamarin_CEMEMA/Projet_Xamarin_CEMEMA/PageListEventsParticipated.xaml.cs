using System.Collections.ObjectModel;
using Projet_Xamarin_CEMEMA.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projet_Xamarin_CEMEMA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListEventsParticipated : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        ListEvent listEvent = new ListEvent();

        public PageListEventsParticipated()
        {
            InitializeComponent();

            foreach (EvenementModel evenement in listEvent.evenements)
            {
                Items.Add(evenement.Name);
            }

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            // Choose between see event or not to participate
            bool answer = await DisplayAlert(e.Item.ToString(), "What do you want?", "See", "Not Interested");

            // If click on "Not Interested" event is delete of the list
            if (answer == false)
            {
                Items.Remove(e.Item.ToString());
            }
            // If click on "See" go to the page event info
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
