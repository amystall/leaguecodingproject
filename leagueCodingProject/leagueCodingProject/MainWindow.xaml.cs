using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
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
            //Tim you need to replace this API key when you run this program with the regenerated one. Text me or I can include the instructions.
            string apikey = "RGAPI-a2ab5587-dfed-43f8-a906-357d6ab0baf5";
            //variable creation
            Dictionary<string, int> champions = new Dictionary<string, int>();
            champions.Add("Aatrox", 1);
            champions.Add("Ahri", 2);
            champions.Add("Akali", 3);
            champions.Add("Alistar", 4);
            champions.Add("Amumu", 5);
            champions.Add("Anivia", 6);
            champions.Add("Annie", 7);
            champions.Add("Ashe", 8);
            champions.Add("Aurelion Sol", 9);
            champions.Add("Azir", 10);
            champions.Add("Bard", 11);
            champions.Add("Blitzcrank", 12);
            champions.Add("Brand", 13);
            champions.Add("Braum", 14);
            champions.Add("Caitlyn", 15);
            champions.Add("Camille", 16);
            champions.Add("Cassiopeia", 17);
            champions.Add("Cho'Gath", 18);
            champions.Add("Corki", 19);
            champions.Add("Darius", 20);
            champions.Add("Diana", 21);
            champions.Add("Dr.Mundo", 22);
            champions.Add("Draven", 23);
            champions.Add("Ekko", 24);
            champions.Add("Elise", 25);
            champions.Add("Evelynn", 26);
            champions.Add("Ezreal", 27);
            champions.Add("Fiddlesticks", 28);
            champions.Add("Fiora", 29);
            champions.Add("Fizz", 30);
            champions.Add("Galio", 31);
            champions.Add("Gangplank", 32);
            champions.Add("Garen", 33);
            champions.Add("Gnar", 34);
            champions.Add("Gragas", 35);
            champions.Add("Graves", 36);
            champions.Add("Hecarim", 37);
            champions.Add("Heimerdinger", 38);
            champions.Add("Illaoi", 39);
            champions.Add("Irelia", 40);
            champions.Add("Ivernz", 41);
            champions.Add("Janna", 42);
            champions.Add("Jarvan IV", 43);
            champions.Add("Jax", 44);
            champions.Add("Jayce", 45);
            champions.Add("Jhin", 46);
            champions.Add("Jinx", 47);
            champions.Add("Kai'Sa", 48);
            champions.Add("Kalista", 49);
            champions.Add("Karma", 50);
            champions.Add("Karthus", 51);
            champions.Add("Kassadin", 52);
            champions.Add("Katarina", 53);
            champions.Add("Kayle", 54);
            champions.Add("Kayn", 55);
            champions.Add("Kennen", 56);
            champions.Add("Kha'Zix", 57);
            champions.Add("Kindred", 58);
            champions.Add("Kled", 59);
            champions.Add("Kog'Maw", 60);
            champions.Add("LeBlanc", 61);
            champions.Add("Lee Sin", 62);
            champions.Add("Leona", 63);
            champions.Add("Lissandra", 64);
            champions.Add("Lucian", 65);
            champions.Add("Lulu", 66);
            champions.Add("Lux", 67);
            champions.Add("Malphite", 68);
            champions.Add("Malzahar", 69);
            champions.Add("Maokai", 70);
            champions.Add("Master Yi", 71);
            champions.Add("Miss Fortune", 72);
            champions.Add("Mordekaiser", 73);
            champions.Add("Morgana", 74);
            champions.Add("Nami", 75);
            champions.Add("Nasus", 76);
            champions.Add("Nautilus", 77);
            champions.Add("Neeko", 78);
            champions.Add("Nidalee", 79);
            champions.Add("Nocturne", 80);
            champions.Add("Nunu & Willump", 81);
            champions.Add("Olaf", 82);
            champions.Add("Orianna", 83);
            champions.Add("Ornn", 84);
            champions.Add("Pantheon", 85);
            champions.Add("Poppy", 86);
            champions.Add("Pyke", 87);
            champions.Add("Quinn", 88);
            champions.Add("Rakan", 89);
            champions.Add("Rammus", 90);
            champions.Add("Rek'Sai", 91);
            champions.Add("Renekton", 92);
            champions.Add("Rengar", 93);
            champions.Add("Riven", 94);
            champions.Add("Rumble", 95);
            champions.Add("Ryze", 96);
            champions.Add("Sejuani", 97);
            champions.Add("Shaco", 98);
            champions.Add("Shen", 99);
            champions.Add("Shyvana", 100);
            champions.Add("Singed", 101);
            champions.Add("Sion", 102);
            champions.Add("Sivir", 103);
            champions.Add("Skarner", 104);
            champions.Add("Sona", 105);
            champions.Add("Soraka", 106);
            champions.Add("Swain", 107);
            champions.Add("Sylas", 108);
            champions.Add("Syndra", 109);
            champions.Add("Tahm Kench", 110);
            champions.Add("Taliyah", 111);
            champions.Add("Talon", 112);
            champions.Add("Taric", 113);
            champions.Add("Teemo", 114);
            champions.Add("Thresh", 115);
            champions.Add("Tristana", 116);
            champions.Add("Trundle", 117);
            champions.Add("Tryndamere", 118);
            champions.Add("Twisted Fate", 119);
            champions.Add("Twitch", 120);
            champions.Add("Udyr", 121);
            champions.Add("Urgot", 122);
            champions.Add("Varus", 123);
            champions.Add("Vayne", 124);
            champions.Add("Veigar", 125);
            champions.Add("Vel'Koz", 126);
            champions.Add("Vi", 127);
            champions.Add("Viktor", 128);
            champions.Add("Vladimir", 129);
            champions.Add("Volibear", 130);
            champions.Add("Warwick", 131);
            champions.Add("Wukong", 132);
            champions.Add("Xayah", 133);
            champions.Add("Xerath", 134);
            champions.Add("Xin Zhao", 135);
            champions.Add("Yasuo", 136);
            champions.Add("Yorick", 137);
            champions.Add("Zac", 138);
            champions.Add("Zed", 139);
            champions.Add("Ziggs", 140);
            champions.Add("Zilean", 141);
            champions.Add("Zoe", 142);
            champions.Add("Zyra", 143);

            //characters
            string topbluecharacter = txbTopblue.Text;
            string midbluecharacter = txbMidblue.Text;
            string junglebluecharacter = txbJungleblue.Text;
            string adcbluecharacter = txbBlueADC.Text;
            string supportbluecharacter = txbBluesupport.Text;
            string topredcharacter = txbTopred.Text;
            string midredcharacter = txbMidred.Text;
            string jungleredcharacter = txbRedjungle.Text;
            string adcredcharacter = txbRedADC.Text;
            string supportredcharacter = txbRedSupport.Text;

            //players
            string bluetopplayer = txbTopbluePlayer.Text;
            string bluemidplayer = txbMidbluePlayer.Text;
            string bluejgplayer = txbJunglebluePlayer.Text;
            string blueadcplayer = txbBlueADC.Text;
            string bluesupportplayer = txbBluesupportPlayer.Text;
            string redtopplayer = txbTopredPlayer.Text;
            string redmidplayer = txbMidredPlayer.Text;
            string redjgplayer = txbRedjunglePlayer.Text;
            string redadcplayer = txbRedADCPlayer.Text;
            string redsupportplayer = txbRedSupportPlayer.Text;

            List<string> players = new List<string>();
            players.Add(bluetopplayer);
            players.Add(bluemidplayer);
            players.Add(bluejgplayer);
            players.Add(blueadcplayer);
            players.Add(bluesupportplayer);
            players.Add(redtopplayer);
            players.Add(redmidplayer);
            players.Add(redjgplayer);
            players.Add(redadcplayer);
            players.Add(redsupportplayer);

            List<string> characters = new List<string>();
            characters.Add(topbluecharacter);
            characters.Add(midbluecharacter);
            characters.Add(junglebluecharacter);
            characters.Add(adcbluecharacter);
            characters.Add(supportbluecharacter);
            characters.Add(topredcharacter);
            characters.Add(midredcharacter);
            characters.Add(jungleredcharacter);
            characters.Add(adcredcharacter);
            characters.Add(supportredcharacter);
            //getting player ID's

            Dictionary<string, string> playerCharacter = new Dictionary<string, string>();
            playerCharacter.Add(bluetopplayer, topbluecharacter);
            playerCharacter.Add(bluemidplayer, midbluecharacter);
            playerCharacter.Add(bluejgplayer, junglebluecharacter);
            playerCharacter.Add(blueadcplayer, adcbluecharacter);
            playerCharacter.Add(bluesupportplayer, supportbluecharacter);
            playerCharacter.Add(redtopplayer, topredcharacter);
            playerCharacter.Add(redmidplayer, midredcharacter);
            playerCharacter.Add(redjgplayer, jungleredcharacter);
            playerCharacter.Add(redadcplayer, adcredcharacter);
            playerCharacter.Add(redsupportplayer, supportredcharacter);


            List<summonerName> summonerNames = new List<summonerName>();

            using (HttpClient client = new HttpClient())
            {
                foreach (var item in playerCharacter)
                {
                    var response = client.GetAsync($@"https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{item.Key}?api_key={apikey}").Result;
                    if(response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        summonerName summoner = JsonConvert.DeserializeObject<summonerName>(content);
                        summonerNames.Add(summoner);
                    }
                }

                foreach (summonerName item in summonerNames)
                {
 
                    var response = client.GetAsync($@"https://na1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/{item.id}/by-champion/{playerCharacter[item.name]}").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        champtionMastery playermastery = JsonConvert.DeserializeObject<champtionMastery>(content);
                        THIS

                    }
                }
            }
            

        }



        //this can probably be changed to a double but I don't want to deal with the red line right now
        public void CalculateWinRate()
        {
            //Tim you need to replace this API key when you run this program
            string apikey = "RGAPI-476876c7-0e62-422c-bf99-daac75584f97";
            using (HttpClient client = new HttpClient())
            {
                //putting all the list up here
                List<matchlistByDivision> matchlistd = new List<matchlistByDivision>();
                List<summonerName> accountinfo = new List<summonerName>();
                var response = client.GetAsync($@"https://na1.api.riotgames.com/lol/league/v4/entries/RANKED_SOLO_5x5/DIAMOND/I?api_key={apikey}").Result;
                if (response.IsSuccessStatusCode)
                {

                    var content = response.Content.ReadAsStringAsync().Result;
                    string[] soloplayer = content.Split('}');
                    foreach (var item in soloplayer)
                    {
                        var newitem = "";
                        if (item == "")
                        {

                        }
                        else if (item == "]")
                        {

                        }
                        else
                        {
                            newitem = item + "}";
                            newitem = newitem.Replace("[", null);
                            newitem = newitem.Replace("},", "}");
                            newitem = newitem.Replace(",{", "{");
                            if (newitem.Contains("\"leaguePoints\":100"))
                            {
                                newitem = newitem.Replace("}", "}}");
                            }
                            matchlistByDivision playerindivision = JsonConvert.DeserializeObject<matchlistByDivision>(newitem);
                            matchlistd.Add(playerindivision);
                        }



                    }

                    int counter = 0;
                    foreach (var item in matchlistd)
                    {
                        //need an if that keeps track of how many queries have gone on and then resets the number if its too high

                        var response2 = client.GetAsync($@"https://na1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{item.summonerName}?api_key={apikey}").Result;

                        counter++;
                        if (response2.IsSuccessStatusCode)
                        {
                            var content2 = response2.Content.ReadAsStringAsync().Result;
                            var headerresponse = response2.Headers;
                            if (response2.Content.Headers.Contains("X-App-Rate-Limit-Count: 3:1"))
                            {
                                Thread.Sleep(1000);
                            }

                            summonerName player = JsonConvert.DeserializeObject<summonerName>(content2);
                            accountinfo.Add(player);

                        }
                    }
                        MessageBox.Show("YOU MADE IT PAST THE SECOND LOOP :D");
                        /*
                        foreach (var item in second list)
                        {
                            //make sure to fix the item.
                            var response3 = client.GetAsync($@"https://na1.api.riotgames.com/lol/match/v4/matchlists/by-account/{item.accountid}?api_key=RGAPI-fc04a15c-8c7f-4294-9010-b971c873f2eb").Result;
                            if(response3.IsSuccessStatusCode)
                            {
                                var content3 = response3.Content.ReadAsStringAsync().Result;
                                //put into list part
                            }
                        }

                        foreach (var item in third list)
                        {
                            //make sure to fix the item in here
                            var response4 = client.GetAsync($@"https://na1.api.riotgames.com/lol/match/v4/matches/{item.matchid}").Result;
                            if (response4.IsSuccessStatusCode)
                            {

                            }

                        } 
                        */


                    }
                }
            }
        }
    }

