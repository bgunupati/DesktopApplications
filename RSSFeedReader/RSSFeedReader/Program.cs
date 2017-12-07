using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RSSFeedReader
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                foreach (EntityRSS objrss in ParseRssFile())
                {
                    Console.WriteLine(objrss.RssID + ". " + objrss.RSSTitle);
                }
                Console.WriteLine("Choose Line nunmber to print title and description");
                int selctedID = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("TITLE : " + ParseRssFile().FirstOrDefault(rss => rss.RssID == selctedID).RSSTitle);
                Console.WriteLine("DSCRIPTION : " + Environment.NewLine + ParseRssFile().FirstOrDefault(rss => rss.RssID == selctedID).Description);
                Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine);
                Console.WriteLine("Press any key to continue ...");
                Console.ReadKey();
            }
        }

        private static List<EntityRSS> ParseRssFile()
        {
            EntityRSS objEntity = null;

            List<EntityRSS> objListEntity  = new List<EntityRSS>();

            XmlDocument rssXmlDoc = new XmlDocument();

            // Load the RSS file from the RSS URL
            rssXmlDoc.Load("http://finance.yahoo.com/rss/headline?s=NKE");

            // Parse the Items in the RSS file
            XmlNodeList rssNodes = rssXmlDoc.SelectNodes("rss/channel/item");

            StringBuilder rssContent = new StringBuilder();

            Dictionary<int, string> dicRSSFeed = new Dictionary<int, string>();

            int IDConter = 1;
            // Iterate through the items in the RSS file
            foreach (XmlNode rssNode in rssNodes)
            {
                objEntity = new EntityRSS();

                objEntity.RssID = IDConter;
                XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                objEntity.RSSTitle = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("link");
                objEntity.Link = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("description");
                objEntity.Description = rssSubNode != null ? rssSubNode.InnerText : "";

                objListEntity.Add(objEntity);

                IDConter ++;
            }
            
            return objListEntity;
        }
    }
}
