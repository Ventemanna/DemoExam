using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Models
{
    public class Status
    {
        static public int counterEnteties = 0;

        public int Id { get; }
        public string Name { get; set; }

        public Status(string name)
        {
            counterEnteties++;
            Id = counterEnteties;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
