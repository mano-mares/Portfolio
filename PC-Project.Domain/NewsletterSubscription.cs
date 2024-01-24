using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Project.Domain
{
    public class NewsletterSubscription
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Preferences { get; set; }
        
        public DateTime SubscriptionDate { get; set; }

        public virtual UserAccount User { get; set; }

    }
}
