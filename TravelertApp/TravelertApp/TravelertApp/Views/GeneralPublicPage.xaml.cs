using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelertApp.Models;
using TravelertApp.Views.ProfilePageUsers;
using TravelertApp.Views.RegisterUsers;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace TravelertApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class GeneralPublicPage : ContentPage
    {
        private string ConsumerUID;
        public GeneralPublicPage(string consumerUID)
        {
            InitializeComponent();
            ConsumerUID = consumerUID;

            #region DesiredVehicle Picker
            //Calling DesiredVehicle picker to add elements
            DesiredVehicle.Items.Add("Class 1: Car, Jeepney, Van, Pickup, Motorcycle, Tricycle");
            DesiredVehicle.Items.Add("Class 2: Bus, Truck, Trailer Vehicle");
            DesiredVehicle.Items.Add("Class 3: Large Truck, Large Truck w/Trailer");
            DesiredVehicle.Items.Add("Train, Boat and Airplane");
            #endregion DesiredVehicle Picker

            Pin pinPUP = new Pin()
            {
                Type = PinType.Place,
                Label = "PUP CEA",
                Address = "Anonas, Sta. Mesa, Maynila, 1008 Kalakhang Maynila",
                Position = new Position(14.598978493230458d, 121.00537569264561d),
                Rotation = 33.3f,
                Tag = "id_tokyo",

            };
            map.Pins.Add(pinPUP);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(pinPUP.Position, Distance.FromMeters(5000)));


            //Setting MyMenu to get the list of Menu
            //MyMenu = GetMenus();

            //Setting the binding contxt of this page to itself
            // - to bring the data from this page
            //this.BindingContext = this;

            #region GestureRecognizers

            //tapgesturerecognizer experiment
            //var tapGestureRecognizerHomePage = new TapGestureRecognizer();
            //tapGestureRecognizerHomePage.Tapped += async (s, e) => {
            //    // handle the tap
            //    await Navigation.PushAsync(new GeneralPublicPage(ConsumerUID));
            //};
            //Lbl_GoToHomePage.GestureRecognizers.Add(tapGestureRecognizerHomePage);

            //var tapGestureRecognizerProfilePage = new TapGestureRecognizer();
            //tapGestureRecognizerProfilePage.Tapped += async (s, e) => {
            //    // handle the tap
            //    await Navigation.PushAsync(new ConsumerProfilePage(ConsumerUID));
            //};
            //Lbl_GoToProfilePage.GestureRecognizers.Add(tapGestureRecognizerProfilePage);

            //var tapGestureRecognizerSettingsPage = new TapGestureRecognizer();
            //tapGestureRecognizerSettingsPage.Tapped += async (s, e) => {
            //    // handle the tap
            //    await Navigation.PushAsync(new ConsumerSettingsPage(ConsumerUID));
            //};
            //Lbl_GoToSettingsPage.GestureRecognizers.Add(tapGestureRecognizerSettingsPage);
            #endregion GestureRecognizers

        }

        //public List<GenPublicMenu> MyMenu { get; set; }

        //private List<GenPublicMenu> GetMenus()
        //{
        //    return new List<GenPublicMenu>
        //    {
        //        new GenPublicMenu{Name = "Home", Icon = "home.png" },
        //        new GenPublicMenu{Name = "Profile", Icon = "user.png"},
        //        new GenPublicMenu{Name = "Settings", Icon = "settings.png"},
        //    };
        //}

        private void DesiredVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Open Swipe animation 
        // - the paramerers of ScaleYTo are
        // - 1. setting it to 0.9 (ung scale ata to)
        // - 2. milliseconds
        // - 3. ??

        //private void OpenSwipe(object sender, EventArgs e)
        //{
        //    //anytime we want to open the swipe view, we're just going to call the MainSwipeView and take the open method
        //    // - and within that, we indicate the item that we want to open
        //    MainSwipeView.Open(OpenSwipeItem.LeftItems);
        //}
        //private void CloseSwipe(object sender, EventArgs e)
        //{
        //    //when we want to close the swipe view, we call the close method
        //    MainSwipeView.Close();
        //}

        //async private void GoToHome(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new GeneralPublicPage());
        //}

        //async private void GoToProfile(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new ConsumerProfilePage(email));
        //}
        //async private void GoToSettings(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new ConsumerSettingsPage());
        //}
    }
    //public class GenPublicMenu
    //{
    //    public string Name { get; set; }
    //    public string Icon { get; set; }

    //}
}

