using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppRoach.WebApi.Models
{
    public class Circle
    {
        public int CircleID { get; set; }

        public String Title { get; set; }

        public String Description { get; set; }

        public bool isPublic { get; set; }
    }
}