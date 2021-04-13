using Projet_Xamarin_CEMEMA.Model;
using Xamarin.Forms;

namespace Projet_Xamarin_CEMEMA
{
    public partial class PageEventInfo : ContentPage
    {

        public PageEventInfo(EvenementModel evenement)
        {
            InitializeComponent();

            nameExit.Text = evenement.Name;
            addressExit.Text = evenement.Address;
            postalCodeExit.Text = evenement.PostalCode;
            //cityExit.Text = evenement.City;
            numberExit.Text = evenement.CellularNumber;
            numberMaxOfPeopleExit.Text = evenement.NumberMaxOfPeople;
            dateExit.Text = evenement.Date;
            timeExit.Text = evenement.Time;
            descriptionExit.Text = evenement.Description;
        }
    }
}
