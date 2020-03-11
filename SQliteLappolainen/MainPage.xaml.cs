using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Messaging; 

namespace SQliteLappolainen
{
    
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public bool smsSpam;
        public MainPage()
        {
            InitializeComponent();
            //message();
        }

        /*async void message()
        {
            await DisplayAlert("Alert", "Day!" , "Palju õnne" , "Cancel");
        }*/

        protected override void OnAppearing()
        {
            //friendsList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Friend selectedFriend = (Friend)e.SelectedItem;
            FriendPage friendPage = new FriendPage();
            friendPage.BindingContext = selectedFriend;
             var action = await DisplayActionSheet("Send to?", "Cancel", null, "Email", "Sms", "Call");
                //await DisplayAlert("Внимание", "Осталось меньше 3 дней до ДР!", "Поздравить sms", "Забить"))
                if (smsSpam = true)
                {
                    await DisplayAlert("Уведомление", "Вы уже поздравили" + selectedFriend.Name, "OK");
                }
                switch(action)
                {
                     
                
                    case "Sms":
                    var smsMessenger = CrossMessaging.Current.SmsMessenger;
                    if (smsMessenger.CanSendSms)
                        smsMessenger.SendSms(selectedFriend.Phone, "Здраствуйте" + selectedFriend.Name + selectedFriend.Opis);
                    break; 
                    

                }
                smsSpam = true;
                await Navigation.PushAsync(friendPage);
                
               
            
            
        }
        // обработка нажатия кнопки добавления
        private async void CreateFriend(object sender, EventArgs e)
        {
            Friend friend = new Friend();
            FriendPage friendPage = new FriendPage();
            friendPage.BindingContext = friend;
            await Navigation.PushAsync(friendPage);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Otmaza otmaza = new Otmaza();
            await Navigation.PushAsync(otmaza);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {

            Sending send = new Sending();
            await Navigation.PushAsync(send);
        }
    }
}
