using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatPro.Model
{
    internal class Sale
    {
        public int Id { get; set; }
        public int ClientID { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }

    }
}
