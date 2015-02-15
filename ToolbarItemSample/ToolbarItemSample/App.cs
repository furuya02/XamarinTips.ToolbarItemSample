using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ToolbarItemSample {
    public class App : Application {
        public App() {
            MainPage = new NavigationPage(new MyPage());
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }

    internal class MyPage : ContentPage {
        public MyPage() {
            //「3.テキストメニュー」で使用したサンプルコード
            ToolbarItems.Add(new ToolbarItem{
                Text = "menu1",
                Command = new Command(() => DisplayAlert("Selected", "menu1", "OK"))
            });
            ToolbarItems.Add(new ToolbarItem { Text = "menu2" });
            ToolbarItems.Add(new ToolbarItem { Text = "menu3" });

            //「4.メニューの表示順序」で使用したサンプルコード
            //ToolbarItems.Add(new ToolbarItem { Text = "menu1", Priority = 3 });
            //ToolbarItems.Add(new ToolbarItem { Text = "menu2", Priority = 1 });
            //ToolbarItems.Add(new ToolbarItem { Text = "menu3", Priority = 2 });

            //「5.アイコン表示」で使用したサンプルコード
            //ToolbarItems.Add(new ToolbarItem { Text = "menu1", Icon = "Menu22.png" }); // <-①
            //ToolbarItems.Add(new ToolbarItem { Text = "menu2", Icon = "Menu33.png" }); // <-②
            //ToolbarItems.Add(new ToolbarItem { Text = "menu3", Icon = "Menu44.png" }); // <-③
            //ToolbarItems.Add(new ToolbarItem { Text = "menu4", Icon = "Menu66.png" }); // <-④

            //「6.表示位置」で使用したサンプルコード
            //ToolbarItems.Add(new ToolbarItem {
            //    Text = "menu1",
            //    Icon = "Menu44.png",
            //    Order = ToolbarItemOrder.Primary // <-①
            //}); 
            //ToolbarItems.Add(new ToolbarItem {
            //    Text = "menu2",
            //    Icon = "Menu44.png",
            //    Order = ToolbarItemOrder.Secondary // <-②
            //});




            ////「7.コマンドの記述要領」で使用したサンプルコード
            ////Clickedによるイベント処理
            //var menu1 = new ToolbarItem {Text = "menu1"};
            //menu1.Clicked += (s, a) => {
            //    DisplayAlert("Selected", ((ToolbarItem) s).Text, null, "OK");
            //};
            //ToolbarItems.Add(menu1);

            ////外部メソッドの呼び出し
            //var menu2 = new ToolbarItem {
            //    Text = "menu2",
            //    Command = new Command(Click)
            //};
            //ToolbarItems.Add(menu2);

            ////CommandParameterによるパラメータ渡し
            //var menu3 = new ToolbarItem {
            //    Text = "menu3",
            //    CommandParameter = "menu3",
            //    Command = new Command(key => {
            //        DisplayAlert("Selected", (string) key, null, "OK");
            //    })
            //};
            //ToolbarItems.Add(menu3);

            ////コラムでWindowsPhoneの表示例に使用したコード
            //ToolbarItems.Add(new ToolbarItem { Text = "menu1", Icon = "Icons/Menu22.png" });
            //ToolbarItems.Add(new ToolbarItem { Text = "menu2", Icon = "Icons/Menu33.png" });
            //ToolbarItems.Add(new ToolbarItem { Text = "menu3", Icon = "Icons/Menu44.png" });


        }
        //「7.コマンドの記述要領」で使用したサンプルコード
        //private void Click() {
        //    DisplayAlert("Selected", "menu2", null, "OK");
        //}
    }

}
