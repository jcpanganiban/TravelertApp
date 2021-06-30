//using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelertApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelertApp.Views.RegisterUsers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterEntrepreneurPage : ContentPage
    {
        public RegisterEntrepreneurPage()
        {
            InitializeComponent();
            BusinessType.Items.Add("Sole proprietorship");
            BusinessType.Items.Add("Partnerships");
            BusinessType.Items.Add("Limited liability company (LLC)");
            BusinessType.Items.Add("Corporation");
        }
        async private void Btn_RegisterAsEntrep_Clicked(object sender, EventArgs e)
        {
            try
            {
                //var authProvider = new FirebaseAuthProvider(new FirebaseConfig(Constants.WebAPIkey));
                //var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(Entry_Email_Address.Text, Entry_Password.Text);
                //string gettoken = auth.FirebaseToken;
                //await Application.Current.MainPage.DisplayAlert("Alert", gettoken, "Ok");


                await Navigation.PushAsync(new LoginPage());

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Something went wrong, please try again. {ex.Message}", "Ok");
            }
        }

        private void BusinessType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}