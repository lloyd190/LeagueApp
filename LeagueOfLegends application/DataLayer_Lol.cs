using RiotSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends_application
{
    class DataLayer_Lol
    {
        
        //change method to whatever
         public object getCurrentChampion()
        {
            return null;
        }
         public RiotSharp.SummonerEndpoint.Summoner getPlayer(string name, RiotSharp.Region region)
        {
           var api = RiotApi.GetInstance("RGAPI-2529f152-1b83-4eda-848f-699780609ad4");
            var summoner = (RiotSharp.SummonerEndpoint.Summoner)null;
            try
            {
             summoner = api.GetSummoner(region, name);
               
            }
            catch (RiotSharpException ex)
            {
                Console.Write(ex.Data);
            }
            return summoner;

        }
         public object getChampionById(int id)
        {
            return null;
        }
         public List<int> getGameRecommendedItemBuild(object champion)
        {
            return null;
        }
         public int getPing()
        {
            return 0;
        } 


    }
}
