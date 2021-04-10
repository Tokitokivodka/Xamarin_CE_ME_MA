using System;
using Projet_Xamarin_CEMEMA.Model;
using Xamarin.Forms;

namespace Projet_Xamarin_CEMEMA
{
    public partial class MainPage : ContentPage
    {
        ListEvent listEvent = new ListEvent();

        public MainPage()
        {
            InitializeComponent();

            // Max length of postal code
            entryPostalCode.MaxLength = 5;

            // Max length of cellular number
            entryNumber.MaxLength = 10;

            // Minimun date is Now
            dateOfEvent.MinimumDate = DateTime.Now;
        }

        // Save info when click on button "OK"
        private async void ClickValidate(object sender, EventArgs e)
        {
            // Get value of each entry in the model
            var evenement = new EvenementModel
            {
                Name = entryName.Text,
                Address = entryAddress.Text,
                PostalCode = entryPostalCode.Text,
                CellularNumber = entryNumber.Text,
                NumberMaxOfPeople = entryNumbermaxOfPeople.Text,
                Date = dateOfEvent.Date.ToString("dd/MM/yyyy"),
                Time = timeOfEvent.Time.ToString(),
                Description = entryDescription.Text
            };

            // Add evenement to the list
            listEvent.AddEvent(evenement);

            // Go to the PageEnventInfo
            var newPage = new PageEventInfo(evenement);
            await Navigation.PushAsync(newPage);
        }
    }
}
