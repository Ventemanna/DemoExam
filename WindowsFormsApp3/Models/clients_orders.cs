using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp3.Models
{
    public class Clients_orders
    {
        static public int ClientId { get; set; }
        static public int OrderId { get; set; }

        public Clients_orders(
            int clientId,
            int orderId)
        {
            ClientId = clientId;
            OrderId = orderId;
        }

    }
}
