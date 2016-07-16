using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppRoach.WebApi.Models
{
    public class Event
    {
        public int EventID { get; set; }

        public String Title { get; set; }

        public String Description { get; set; }

        public byte[] Picture { get; set; }

        public byte[] Video { get; set; }

        public int CircleID { get; set; }
    }
}