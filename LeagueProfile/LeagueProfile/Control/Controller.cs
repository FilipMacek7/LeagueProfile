using LeagueProfile.API;
using LeagueProfile.Model;
using LeagueProfile.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueProfile.Control
{
    public class Controller
    {
        public bool GetSummoner(string summonerName)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4(Constant.Region);

            var summoner = summoner_V4.GetSummonerByName(summonerName);

            Constant.Summoner = summoner;

            return summoner != null;
        }
        public object GetContext()
        {
            var summoner = Constant.Summoner;
            var position = GetPosition(summoner);

            return new Profile(summoner.Name, summoner.ProfileIconId, summoner.Level, position.Tier, position.Rank,
                position.Wins, position.Losses);
        }

        private PositionDTO GetPosition(SummonerDTO summoner)
        {
            League_V4 league = new League_V4(Constant.Region);

            var position = league.GetPositions(summoner.Id).Where(p => p.QueueType.Equals("RANKED_SOLO_5x5")).FirstOrDefault();

            return position ?? new PositionDTO();
        }
    }
}
