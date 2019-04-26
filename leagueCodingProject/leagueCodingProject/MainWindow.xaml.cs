using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace leagueCodingProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            CalculateWinRate();
        }

        //this can probably be changed to a double but I don't want to deal with the red line right now
        public void CalculateWinRate()
        {
            string apikey = "RGAPI-a008e059-1e17-4290-ac49-758f3ccc306f";
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync($@"https://na1.api.riotgames.com/lol/league/v4/entries/RANKED_SOLO_5x5/DIAMOND/I?api_key=RGAPI-fc04a15c-8c7f-4294-9010-b971c873f2eb").Result;
                if (response.IsSuccessStatusCode)
                {
                    List<matchlistByDivision> matchlistd = new List<matchlistByDivision>();
                    
                    var content = response.Content.ReadAsStringAsync().Result;
                    IEnumberable<matchlistByDivision> matchlist = JsonConvert.DeserializeObject<matchlistByDivision>(content);
                    //assume amy pulls through and gives me a sweet sweet list

                    //consider using a for loop which is within the rate limits
                    foreach(var item in /*amys list*/)
                    {
                        //make sure to fix the item. in this query sense we dont know what it is yet
                        //RATE LIMITS
                        var response2 = client.GetAsync($@"https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{item.name}?api_key=RGAPI-fc04a15c-8c7f-4294-9010-b971c873f2eb").Result;
                        if (response2.IsSuccessStatusCode)
                        {
                            var content2 = response2.Content.ReadAsStringAsync().Result;
                            //put into list part

                        }
                    }
                    foreach (var item in /*second list*/)
                    {
                        //make sure to fix the item.
                        var response3 = client.GetAsync($@"https://na1.api.riotgames.com/lol/match/v4/matchlists/by-account/{item.accountid}?api_key=RGAPI-fc04a15c-8c7f-4294-9010-b971c873f2eb").Result;
                        if(response3.IsSuccessStatusCode)
                        {
                            var content3 = response3.Content.ReadAsStringAsync().Result;
                            //put into list part
                        }
                    }
                    
                    foreach (var item in /*third list*/)
                    {
                        //make sure to fix the item in here
                        var response4 = client.GetAsync($@"https://na1.api.riotgames.com/lol/match/v4/matches/{item.matchid}").Result;
                        if (response4.IsSuccessStatusCode)
                        {

                        }
                         
                    }


                    
                }
            }
        }
    }
}
