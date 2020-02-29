using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace QouteAcknowledgements.Models
{
    public class Qoute
    {
        public int QouteID { get; set; }
        public bool QuoteAcknowledment { get; set; }
        public string QouteText { get; set; }

    }

    public class QouteDBContext: DbContext
    {
        public DbSet<Qoute> UnacknowledgedQoutes { get; set; }
    }
  

}
