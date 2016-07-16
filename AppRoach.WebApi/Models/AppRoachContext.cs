using System.Data.Entity;

namespace AppRoach.WebApi.Models
{
    public class AppRoachContext : DbContext
    {
        public AppRoachContext()
            : base("DefaultConnection")
        {
        }

        public virtual DbSet<FriendList> FriendLists { get; set; }

        public virtual DbSet<Category> Categories { get; set; }
    }
}