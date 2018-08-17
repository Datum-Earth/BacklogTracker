using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;

namespace BacklogTracker.Dependencies.HLTB.Helpers
{
    internal class HLTBHelper
    {

        public IEnumerable<HtmlNode> FindMainTables(HtmlDocument document)
        {
            var rootNode = document.DocumentNode;
            var mainTables = rootNode.QuerySelectorAll(".game_main_table");

            return mainTables;
        }

        public IEnumerable<HtmlNode> FindBodyTables(HtmlNode rootNode)
        {
            var ret = new List<HtmlNode>();

            // our header nodes have a different class than our normal body nodes, so they go here
            var headerNodes = rootNode.QuerySelectorAll(".back_lighter");
            var bodyNodes = rootNode.QuerySelectorAll(".spreadsheet");

            foreach (var x in headerNodes)
                ret.Add(x);
            foreach (var x in bodyNodes)
                ret.Add(x);

            return ret;
        }

        public IEnumerable<HtmlNode> FindRows(HtmlNode rootNode)
        {
            var rowNodes = rootNode.QuerySelectorAll("tr");

            return rowNodes;
        }

        public IEnumerable<HtmlNode> FindElements(HtmlNode rootNode)
        {
            var tableElements = rootNode.QuerySelectorAll("td");

            return tableElements;
        }

        public bool IsBlackListed(Dictionary<string, IEnumerable<string>> dic)
        {
            // contains the stuff we don't want to get when we're scraping
            List<string> blackList = new List<string>()
            {
                "Platform"
            };

            foreach (string blackListItem in blackList)
            {
                if (dic.ContainsKey(blackListItem))
                    return true;
            }

            return false;
        }
    }
}
