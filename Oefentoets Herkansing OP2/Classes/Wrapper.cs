
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace Oefentoets_Herkansing_OP2.Classes
{
    public class Wrapper
    {
        public static async Task<bool> AddNewVereniging(string Naam, string Type, string Omschrijving)
        {
            Uri request = new Uri(@"https://api.summa.1ku.nl/addclub.php?Name=" + Naam + "&Type=" + Type + "&Description=" + Omschrijving);

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Oefentoets Herkansing OP2");
            HttpResponseMessage respons = await client.GetAsync(request);
            if (respons.IsSuccessStatusCode == false)
            {
                MessageDialog md = new MessageDialog("Het toevoegen van een vereniging is niet gelukt");
                await md.ShowAsync();

                return false;
            }

            respons.EnsureSuccessStatusCode();

            Toevoegen tv = await respons.Content.ReadAsAsync<Toevoegen>();

            return tv.Success;
        }

        public static async Task<List> GetVereniging()
        {
            Uri request = new Uri(@"https://api.summa.1ku.nl/clubs.php");

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User -Agent", "Oefentoets Herkansing OP2");
            HttpResponseMessage respons = await client.GetAsync(request);
            if (respons.IsSuccessStatusCode == false)
            {
                MessageDialog md = new MessageDialog("Het ophalen van de gegevens is niet gelukt");
                await md.ShowAsync();

                return null;
            }

            respons.EnsureSuccessStatusCode();

            Resultaat rs = await respons.Content.ReadAsAsync<Resultaat>();

            return rs.Clubs;
        }
    }
}
