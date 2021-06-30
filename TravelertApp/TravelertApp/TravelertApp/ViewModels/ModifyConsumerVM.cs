using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace TravelertApp.ViewModels
{
    public class ModifyConsumerVM : INotifyPropertyChanged
    {
        public ModifyConsumerVM(string emailConstructorValue)
        {
            Email = emailConstructorValue;
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public Command UpdatePasswordCommand

        {
            get { return new Command(UpdatePassword); }
        }


        private async void UpdatePassword()
        {
            try
            {
                if (!string.IsNullOrEmpty(Password))
                {
                    var isupdate = await FirebaseHelperConsumer.UpdateUser(Email, Password);
                    if (isupdate)
                        await App.Current.MainPage.DisplayAlert("Update Success", "", "Ok");
                    else
                        await App.Current.MainPage.DisplayAlert("Error", "Record not update", "Ok");
                }
                else
                    await App.Current.MainPage.DisplayAlert("Password Require", "Please Enter your password", "Ok");
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Something went wrong, please try again.\n{e.Message} {e.StackTrace}", "Ok");
            }
        }
        public Command DeleteCommand

        {
            get { return new Command(DeleteConsumer); }
        }
        private async void DeleteConsumer()
        {
            try
            {
                var isdelete = await FirebaseHelperConsumer.DeleteUser(Email);
                if (isdelete)
                    await App.Current.MainPage.Navigation.PopAsync();
                else
                    await App.Current.MainPage.DisplayAlert("Error", "Record not delete", "Ok");
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Something went wrong, please try again.\n{e.Message} {e.StackTrace}", "Ok");
            }
        }
        public Command LogoutConsumerCommand
        {
            get
            {
                return new Command(() =>
                {
                    App.Current.MainPage.Navigation.PopAsync();
                });
            }
        }
    }
}
