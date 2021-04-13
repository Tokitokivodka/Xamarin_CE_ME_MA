using System.Collections.ObjectModel;
using Projet_Xamarin_CEMEMA.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projet_Xamarin_CEMEMA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListEventsParticipated : ContentPage
    {
        private ObservableCollection<string> items = new ObservableCollection<string>();
        public ObservableCollection<string> Items { get; set; }

        public PageListEventsParticipated()
        {
            InitializeComponent();

            foreach (EvenementModel evenement in ListEventParticipated.evenements)
            {
                items.Add(evenement.Name);
            }

            MyListView.ItemsSource = items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            bool answer = await DisplayAlert(e.Item.ToString(), "What do you want?", "See", "Not Interested");

            if (answer == false)
            {
                ListEventParticipated.RemoveEvent((EvenementModel)e.Item);
            }
            else
            {
                // Get value of each entry in the model
                //var evenement = ListEvent.FindEvent(e.Item.ToString());

                // Go to the PageEnventInfo
                var newPage = new PageEventInfo((EvenementModel)e.Item);
                await Navigation.PushAsync(newPage);
            }

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
