using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SQliteLappolainen
{
    
        public partial class App : Application
        {
            public const string DATABASE_NAME = "friends.db";
            public static FriendRepository database;
            public static FriendRepository Database
            {
                get
                {
                    if (database == null)
                    {
                        database = new FriendRepository(DATABASE_NAME);
                    }
                    return database;
                }
            }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage())
            {
                
                BarBackgroundColor=Color.FromHex("#ceefe4"),
                BarTextColor = Color.Black

            };
            
            
        }

            protected override void OnStart()
            {
            MainPage.DisplayAlert("Внимание", "Опять в тех не пойдёшь, что на сей раз", "Да", "Нет");
            }

            protected override void OnSleep() { }

            protected override void OnResume() { }
        }
}
