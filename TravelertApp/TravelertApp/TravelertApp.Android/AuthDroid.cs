using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Firebase.Auth;
using TravelertApp.Droid;

//[assembly : Dependency(typeof(AuthDroid))]
namespace TravelertApp.Droid
{
    //public class AuthDroid : IAuth
    //{
    //    public bool IsSignIn()
    //    {
    //        var user = FirebaseAuth.Instance.CurrentUser;
    //        return user != null;
    //    }

    //    public async Task<string> LoginWithEmailAndPassword(string email, string password)
    //    {
    //        try
    //        {
    //            var user = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
    //            var token = user.User.Uid; //- if you want to have a new token every single time
    //            return token;
    //        }
    //        catch (FirebaseAuthInvalidUserException e)
    //        {
    //            e.PrintStackTrace();
    //            return string.Empty;
    //        }
    //        catch (FirebaseAuthInvalidCredentialsException e)
    //        {
    //            e.PrintStackTrace();
    //            return string.Empty;
    //        }
    //    }

    //    public bool SignOut()
    //    {
    //        try
    //        {
    //            FirebaseAuth.Instance.SignOut();

    //            //if it has been signed out
    //            return true;
    //        }
    //        catch(Exception)
    //        {
    //            return false;
    //        }
    //    }

    //    public async Task<string> SignUpWithEmailAndPassword(string email, string password)
    //    {
    //        try
    //        {
    //            var newUser = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);
    //            var token = newUser.User.Uid; //- if you want to have a new token every single time
    //            return token;
    //        }
    //        catch (FirebaseAuthInvalidUserException e)
    //        {
    //            e.PrintStackTrace();
    //            return string.Empty;
    //        }
    //        catch (FirebaseAuthInvalidCredentialsException e)
    //        {
    //            e.PrintStackTrace();
    //            return string.Empty;
    //        }
    //    }
    //}
}