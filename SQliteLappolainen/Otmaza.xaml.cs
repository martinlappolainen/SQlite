using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Messaging;


namespace SQliteLappolainen
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Otmaza : ContentPage
    {
        public bool smsSpam;
        public Otmaza()
        {
            InitializeComponent();
        }

        private async void FriendsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
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
            switch (action)
            {


                case "Sms":
                    var smsMessenger = CrossMessaging.Current.SmsMessenger;
                    if (smsMessenger.CanSendSms)
                        smsMessenger.SendSms(selectedFriend.Phone, "Здраствуйте" + selectedFriend.Name + selectedFriend.Opis);
                    break;


            }
            smsSpam = true;
        }
    }
}