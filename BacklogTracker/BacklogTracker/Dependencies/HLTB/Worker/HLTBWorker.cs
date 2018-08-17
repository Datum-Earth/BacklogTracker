using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using BacklogTracker.Dependencies.HLTB.Helpers;
using System.Text;
using System.Threading.Tasks;

namespace BacklogTracker.Dependencies.HLTB.Worker
{
    internal class HLTBWorker
    {
        private bool IsDebug { get; set; }
        private string DebugFilePath { get; set; }

        public HLTBWorker(bool isDebug, string filePath)
        {
            this.IsDebug = true;
            this.DebugFilePath = filePath;
        }

        public HLTBWorker() { this.IsDebug = false; }

        private IEnumerable<IEnumerable<Dictionary<string, IEnumerable<string>>>> GetGameData(string path)
        {
            var helper = new HLTBHelper();

            using (WebClient webClient = new WebClient())
            {
                var html = new HtmlDocument();

                if (!IsDebug)
                {
                    var htmlSource = webClient.DownloadString(path);
                    html.LoadHtml(htmlSource);
                } else
                {
                    var file = File.ReadAllText(this.DebugFilePath);
                    html.LoadHtml(file);
                }

                var x = helper.FindMainTables(html);
                var masterDicList = new List<List<Dictionary<string, IEnumerable<string>>>>();

                foreach (HtmlNode node in x)
                {
                    var dicList = new List<Dictionary<string, IEnumerable<string>>>();

                    // find our main tables
                    var bodyTables = helper.FindBodyTables(node);
                    foreach (HtmlNode bodyNode in bodyTables)
                    {
                        // make a new dictionary for each body node, so we can reconstruct them later
                        var bodyRecord = new Dictionary<string, IEnumerable<string>>();

                        var rowTables = helper.FindRows(bodyNode);
                        foreach (HtmlNode rowNode in rowTables)
                        {
                            var toAdd = new List<string>();

                            var elementNodes = helper.FindElements(rowNode).ToArray();
                            foreach (HtmlNode elementNode in elementNodes)
                            {
                                toAdd.Add(elementNode.InnerText);
                            }

                            // this is our key in the dictionary
                            var key = toAdd.FirstOrDefault();
                            toAdd.Remove(key); // now we want to remove it so it doesn't show up in our values

                            bodyRecord.Add(key, toAdd);
                        }

                        if (bodyRecord.Count() != 0 && !helper.IsBlackListed(bodyRecord))
                            dicList.Add(bodyRecord);
                    }

                    if (dicList.Count() != 0)
                        masterDicList.Add(dicList);
                }

                return masterDicList;
            }
        }
    }
}
