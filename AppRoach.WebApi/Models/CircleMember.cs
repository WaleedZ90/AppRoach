using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppRoach.WebApi.Models
{
    public class CircleMember
    {
        public int CircleID { get; set; }

        public Circle Circle { get; set; }

        public String MemberID { get; set; }

        public ApplicationUser Member { get; set; }
    }
}