using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
using Firebase.Database.Query;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TravelertApp.Models;
using Xamarin.Forms;

namespace TravelertApp.ViewModels
{
    public class FirebaseHelperConsumer
    {
        public static FirebaseClient firebase = new FirebaseClient("https://travelertappdb-default-rtdb.firebaseio.com/");

        //Read all consumers
        public static async Task<List<Consumer>> GetAllUser()
        {
            try
            {
                var consumerlist = (await firebase
                .Child("Consumers")
                .OnceAsync<Consumer>()).Select(item =>
                new Consumer
                {
                    FullName = item.Object.FullName,
                    Age = item.Object.Age,
                    Username = item.Object.Username,
                    Email = item.Object.Email

                }).ToList();
                return consumerlist;
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Something went wrong, please try again.\n{e.Message} {e.StackTrace}", "Ok");
                return null;
            }
        }

        //Retrieving consumers from the database
        public static async Task<Consumer> GetUser(string email)
        {
            try
            {
                var allConsumers = await GetAllUser();
                await firebase
                .Child("Consumers")
                .OnceAsync<Consumer>();

                return allConsumers.Where(a => a.Email == email).FirstOrDefault();
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Something went wrong, please try again.\n{e.Message} {e.StackTrace}", "Ok");
                return null;
            }
        }

        //Insert a consumer
        public static async Task<bool> AddConsumer(string email, string password)
        {
            try
            {
                await firebase
                .Child("Consumers")
                .PostAsync(new Consumer() { Email = email, Password = password });
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return false;
            }
        }

        //TO BE IMPLEMENTED SA XAML:
        //Updating consumer(TO BE IMPLEMENTED SA XAMARIN FORMS KAYA NAKA COMMNENT)
        public static async Task<bool> UpdateUser(string email, string password)
        {
            try
            {


                var toUpdateConsumer = (await firebase
                .Child("Consumers")
                .OnceAsync<Consumer>()).Where(a => a.Object.Email == email).FirstOrDefault();
                await firebase
                .Child("Consumer")
                .Child(toUpdateConsumer.Key)
                .PutAsync(new Consumer() { Email = email, Password = password });
                return true;
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Something went wrong, please try again.\n{e.Message} {e.StackTrace}", "Ok");
                return false;
            }
        }

        //Deleting User(TO BE IMPLEMENTED SA XAMARIN FORMS KAYA NAKA COMMNENT)
        public static async Task<bool> DeleteUser(string email)
        {
            try
            {
                var toDeleteConsumer = (await firebase
                .Child("Consumers")
                .OnceAsync<Consumer>()).Where(a => a.Object.Email == email).FirstOrDefault();
                await firebase.Child("Users").Child(toDeleteConsumer.Key).DeleteAsync();
                return true;
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Something went wrong, please try again.\n{e.Message} {e.StackTrace}", "Ok");
                return false;
            }
        }
    }
}
