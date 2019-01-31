using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190129_Rss_Api.Model
{
    class HaberModel
    {
        public string link { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime pubDate { get; set; }
        public string image { get; set; }
    }
}
