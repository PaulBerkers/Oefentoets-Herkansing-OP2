using Oefentoets_Herkansing_OP2.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Oefentoets_Herkansing_OP2.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VerenigingToevoegen : Page
    {

        public VerenigingToevoegen()
        {
            this.InitializeComponent();
        }

        private bool _toevoegenResult;

        public bool Toevoegen
        {
            get { return _toevoegenResult; }
            set { _toevoegenResult = value; }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Toevoegen = await Wrapper.AddNewVereniging(tbNaam.Text, tbType.Text, tbOmschrijving.Text);
            if (Toevoegen == true)
            {
                MessageDialog md = new MessageDialog("De nieuwe vereniging is succesvol toegevoegd! (Naam: " + tbNaam.Text + ", " + "Type: " + tbType.Text + ", " + "Omschrijving: " + ", " + tbOmschrijving.Text);
                await md.ShowAsync();
                tbNaam.Text = "";
                tbType.Text = "";
                tbOmschrijving.Text = "";
            }
            else
            {
                MessageDialog md = new MessageDialog("Kan geen API aanroepen omdat je niet alle gegevens hebt ingevuld!");
                await md.ShowAsync();
            }
        }
    }
}
