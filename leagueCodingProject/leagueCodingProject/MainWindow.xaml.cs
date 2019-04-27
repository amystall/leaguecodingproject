﻿using Newtonsoft.Json;
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
            CalculateWinRate();
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

