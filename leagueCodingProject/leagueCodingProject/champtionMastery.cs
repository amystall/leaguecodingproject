using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leagueCodingProject
{
    class champtionMastery
    {
        public Boolean chestGranted { get; set; }
        public int championLevel { get; set; }
        public int champtionPoints { get; set; }
        public long championId { get; set; }
        public long championPointsUntilNextLevel { get; set; }
        public long lastPlayTime { get; set; }
        public int tokensEarned { get; set; }
        public long championPointsSinceLastLevel { get; set; }
        public string summonerId { get; set; }
    }
}
