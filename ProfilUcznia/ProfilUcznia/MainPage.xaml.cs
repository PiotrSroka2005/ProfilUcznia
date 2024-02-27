using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProfilUcznia
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PublicClass.Clases.Add(new UserClass("4TP", "https://zstio.edu.pl/plan/u/podzgodz/plan.php?kl=123F69DA832927A6"));
            PublicClass.Clases.Add(new UserClass("3TP", "https://zstio.edu.pl/plan/u/podzgodz/plan.php?kl=7C176FB779BD7149"));
            PublicClass.Clases.Add(new UserClass("5TP", "https://zstio.edu.pl/plan/u/podzgodz/plan.php?kl=2FE6DBDB64885790"));
            PublicClass.accounts.Add(new Account("Piotr", "1234", PublicClass.Clases[0]));            
        }

        private void Register(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}
