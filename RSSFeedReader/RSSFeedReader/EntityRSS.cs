using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeedReader
{
    public class EntityRSS
    {
        public int RssID { get; set; }
        public string RSSTitle { get; set; }
        public string Description { get; set; }

        public string Link { get; set; }
        public EntityRSS()
        {
        }
    }
}
