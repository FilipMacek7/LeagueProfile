using LeagueProfile.API;
using LeagueProfile.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueProfile.Control
{
    public class MainController
    {
        public bool GetSummoner(string summonerName)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4(Constant.Region);

            var summoner = summoner_V4.GetSummonerByName(summonerName);

            Constant.Summoner = summoner;

            return summoner != null;
        }
    }
}
