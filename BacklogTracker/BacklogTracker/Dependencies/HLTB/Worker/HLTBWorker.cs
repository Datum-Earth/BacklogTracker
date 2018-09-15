using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using BacklogTracker.Dependencies.HLTB.Helpers;
using System.Text;
using System.Threading.Tasks;
using BacklogTracker.Dependencies.HLTB.POCO;

namespace BacklogTracker.Dependencies.HLTB.Worker
{
    internal class HLTBWorker
    {
        private HLTBHelper Helper { get; set; }
        public bool IsDebug { get; set; }

        public HLTBWorker()
        {
            this.Helper = new HLTBHelper();
        }

        public HLTBRecord GetGameData(string path)
        {
            using (WebClient webClient = new WebClient())
            {
                var html = new HtmlDocument();

                if (!IsDebug)
                {
                    var htmlSource = webClient.DownloadString(path);
                    html.LoadHtml(htmlSource);
                } else
                {
                    var file = File.ReadAllText(path);
                    html.LoadHtml(file);
                }

                var name = Helper.FindGameName(html);
                var categories = GetCategories(Helper.FindMainTables(html));

                return new HLTBRecord(name, categories);
            }
        }

        private List<HLTBCategory> GetCategories(IEnumerable<HtmlNode> nodes)
        {
            List<HLTBCategory> ret = new List<HLTBCategory>();

            foreach (HtmlNode node in nodes)
            {
                ret.Add(GetCategory(node));
            }

            return ret;
        }

        private HLTBCategory GetCategory(HtmlNode node)
        {
            var rowTables = Helper.FindRows(node).ToArray();

            HLTBCategory category = new HLTBCategory();

            for (int i = 0; i < rowTables.Count(); i++)
            {
                var subCategoryValues = new List<string>();

                var elementNodes = Helper.FindElements(rowTables[i]).ToArray();
                foreach (HtmlNode elementNode in elementNodes)
                {
                    subCategoryValues.Add(elementNode.InnerText);
                }

                var subCategoryArray = subCategoryValues.ToArray<string>();

                // if this is the first 'subcategory' then this actually contains our category name and headers
                if (i == 0)
                {
                    for (int j = 0; j < subCategoryArray.Length; j++)
                    {
                        if (j == 0)
                        {
                            category.Name = subCategoryArray[j];
                            continue;
                        }

                        if (category.Headers == null)
                        {
                            category.Headers = new string[subCategoryArray.Length];
                        }

                        category.Headers[j] = subCategoryArray[j];
                    }

                    continue;
                }

                var subCategory = new HLTBSubCategory(subCategoryArray);

                category.SubCategories.Add(subCategory);
            }

            return category;
        }
    }
}
