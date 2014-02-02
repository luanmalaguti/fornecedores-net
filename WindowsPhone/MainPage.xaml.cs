using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WindowsPhone.Resources;

namespace WindowsPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        WsPedidos.WsPedidosClient client = new WsPedidos.WsPedidosClient();
        HashSet<String> pedidos = new HashSet<string>();
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            client.GetAllCompleted += client_GetAllCompleted;
            

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        void client_GetAllCompleted(object sender, WsPedidos.GetAllCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                int i = e.Result.Count;
                foreach(var n in e.Result){
                    pedidos.Add(n.Id + " - "+n.Descricao);
                }
            }
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}