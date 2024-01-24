using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Project.Domain
{
    public class Wishlist
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        
        public virtual UserAccount User {  get; set; }
        public virtual ICollection<WishlistItem> WishlistItem { get; set; }
    }
}
