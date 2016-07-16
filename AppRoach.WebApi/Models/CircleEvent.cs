using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppRoach.WebApi.Models
{
    public class CircleEvent
    {
        [Key, Column(Order = 0)]
        public int CircleID { get; set; }

        public Circle Circle { get; set; }

        [Key, Column(Order = 1)]
        public int EventID { get; set; }

        public Event Event { get; set; }
    }
}