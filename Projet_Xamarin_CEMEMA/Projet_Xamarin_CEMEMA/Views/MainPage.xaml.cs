using System.Collections.Generic;
using System.Linq;
using Projet_Xamarin_CEMEMA.Model;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Map = Xamarin.Forms.Maps.Map;

namespace Projet_Xamarin_CEMEMA
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            Map map = new Map();
            Content = map;
            
            var mapPosition = new Position(43.65, 6.9833);
            var mapSpan = MapSpan.FromCenterAndRadius(mapPosition, Distance.FromMiles(2));
            map.MoveToRegion(mapSpan);
            
            Pin pin = new Pin()
            {
                   Label = "Soiree1",
                   Address = "6 chemin de l'oratoire, Plascassier, France",
                   Type = PinType.Place,
                   Position = new Position(43.65, 6.9833)
            };
            map.Pins.Add(pin);

            pin.MarkerClicked += async (s, args) =>
            {
                args.HideInfoWindow = true;

                string pinName = ((Pin)s).Label;

                bool answer = await DisplayAlert(pinName, "What dou you want?", "Interrested", "Cancel");

                if (answer == false)
                {
                }
                else
                {
                    // Add event to list event participated
                    EvenementModel evt = ListEvent.FindEvent(pinName);
                    ListEventParticipated.AddEvent(evt);
                }
            };

        }
    }
}
