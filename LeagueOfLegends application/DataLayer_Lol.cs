using RiotSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegends_application
{
   static class DataLayer_Lol
    {
        
        //change object to whatever you named the class
        static public object getCurrentChampion()
        {
            return null;
        }
        static public RiotSharp.SummonerEndpoint.Summoner getPlayer(string name)
        {
           var api = RiotApi.GetInstance("RGAPI-2529f152-1b83-4eda-848f-699780609ad4");
            var summoner = api.GetSummoner(Region.euw, "illumi Trackball");
            try
            {

               
            }
            catch (RiotSharpException ex)
            {
                Console.Write(ex.Data);
            }
            return null;

        }
        static public object getChampionById(int id)
        {
            return null;
        }
        static public List<int> getGameRecommendedItemBuild(object champion)
        {
            return null;
        }
        static public int getPing()
        {
            return 0;
        } 


    }
}
