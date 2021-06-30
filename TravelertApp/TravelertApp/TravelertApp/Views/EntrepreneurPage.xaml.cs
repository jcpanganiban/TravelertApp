using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelertApp.Views.ProfilePageUsers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelertApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class EntrepreneurPage : ContentPage
    {
        public EntrepreneurPage()
        {
            InitializeComponent();
            //MyMenu = GetMenus();
            //this.BindingContext = this; 
        }
        
        //public List<EntrepMenu> MyMenu { get; set; }
        //private List<EntrepMenu> GetMenus()
        //{
        //    return new List<EntrepMenu>
        //    {
        //        new EntrepMenu{Name = "Home", Icon = "home.png" },
        //        new EntrepMenu{Name = "Profile", Icon = "user.png"},
        //        new EntrepMenu{Name = "Settings", Icon = "settings.png"},
        //    };
            
        //}

        private void OpenSwipe(object sender, EventArgs e)
        {
            MainSwipeView.Open(OpenSwipeItem.LeftItems);
        }
        private void CloseSwipe(object sender, EventArgs e)
        {
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

    //public class EntrepMenu
    //{
    //    public string Name { get; set; }
    //    public string Icon { get; set; }
    //}
}

