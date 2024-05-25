using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Models
{
    public class Order
    {
        static public int counterEntities = 0;

        public int Id { get; }
        public string Car_number { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }

        public Order(
            string car_number,
            string description,
            Status status
            )
        {
            counterEntities++;
            this.Car_number = car_number;
            this.Description = description;
            this.Status = status;
        }


    }
}
