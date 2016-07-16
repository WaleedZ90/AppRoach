using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppRoach.WebApi.Models
{
    public class FriendList
    {
        [Key, Column(Order = 0)]
        public String UserID { get; set; }

        public ApplicationUser User { get; set; }

        [Key, Column(Order = 1)]
        public String FriendID { get; set; }

        public List<ApplicationUser> Friends { get; set; }
    }
}