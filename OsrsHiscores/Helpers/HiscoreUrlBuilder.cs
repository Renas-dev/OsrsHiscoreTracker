using System;

namespace OsrsHiscores.Helpers
{
    internal static class HiscoreUrlBuilder
    {
        public static string BuildIronmanUrl(string userName)
        {
            string baseUrl = "https://secure.runescape.com/m=hiscore_oldschool/index_lite.ws?player=";
            userName = Uri.EscapeDataString(userName);
            string HiscoreUrl = ($"{baseUrl}{userName}");
            return  HiscoreUrl;
        }
    }
}
