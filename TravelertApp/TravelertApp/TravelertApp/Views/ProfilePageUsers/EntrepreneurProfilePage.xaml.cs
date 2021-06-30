using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelertApp.Views.ProfilePageUsers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntrepreneurProfilePage : ContentPage
    {
        public EntrepreneurProfilePage()
        {
            InitializeComponent();

            //Setting MyMenu to get the list of Menu
            MyMenu = GetMenus();

            //Setting the binding contxt of this page to itself
            // - to bring the data from this page
            this.BindingContext = this;

            //
        }
        public List<EntrepProfileMenu> MyMenu { get; set; }

        private List<EntrepProfileMenu> GetMenus()
        {
            return new List<EntrepProfileMenu>
            {
                new EntrepProfileMenu{Name = "Home", Icon = "home.png" },
                new EntrepProfileMenu{Name = "Profile", Icon = "user.png"},
                new EntrepProfileMenu{Name = "Settings", Icon = "settings.png"},
            };
        }

        private void Btn_Logout_Clicked(object sender, EventArgs e)
        {
            Preferences.Remove("MyFirebaseRefreshToken");
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
        private void OpenSwipe(object sender, EventArgs e)
        {
            
        }

        private void CloseSwipe(object sender, EventArgs e)
        {
            //when we want to close the swipe view, we call the close method
            MainSwipeView.Close();
        }

        async private void GoToHome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntrepreneurPage());
        }
        async private void GoToProfile(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntrepreneurProfilePage());
        }
        async private void GoToSettings(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntrepreneurSettingsPage());
        }
    }
    public class EntrepProfileMenu
    {
        public string Name { get; set; }
        public string Icon { get; set; }

    }
}