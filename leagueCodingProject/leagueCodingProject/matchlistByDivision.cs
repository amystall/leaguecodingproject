using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leagueCodingProject
{
    class matchlistByDivision
    {
        public string queueType { get; set; }
        public string summonerName { get; set; }
        public Boolean hotStreak { get; set; }
        public int wins { get; set; }
        public Boolean veteran { get; set; }
        public int losses { get; set; }
        public string rank { get; set; }
        public string leagueId { get; set; }
        public Boolean inactive { get; set; }
        public Boolean freshBlood { get; set; }
        public string tier { get; set; }
        public string summonerId { get; set; }
        public int leaguePoints { get; set; }
        public MiniSeries miniSeries { get; set; }
    }
}
