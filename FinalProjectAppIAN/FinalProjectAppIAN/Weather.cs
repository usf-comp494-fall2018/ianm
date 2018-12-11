using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Runtime.Serialization;
using System.Net;
using Windows.UI.Xaml;

namespace FinalProjectAppIAN
{

    public class Weather

    {

        public int id { get; set; }

        public int period { get; set; }

        public string Icon { get; set; }

        public string Title { get; set; }

        public string Fcttext { get; set; }

        public string Lastcheck { get; set; }

        public string Source
        {
            get
            {
                return Title + " : " + Fcttext;
            }
        }
    }

    //public RoutedEventHandler Page_Loaded { get; private set; }
}
