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
                var response = client.GetAsync($@"https://na1.api.riotgames.com/lol/league/v4/entries/RANKED_SOLO_5x5/DIAMOND/I?api_key=RGAPI-a008e059-1e17-4290-ac49-758f3ccc306f").Result;
                if (response.IsSuccessStatusCode)
                {

                }
            }
        }
    }
}
