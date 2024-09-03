using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefentoets.Models
{
    public class Vehicle
    {
        private string description;
        private string licensePlate;

        public Vehicle(string Description, string LicensePlate)
        {
            description = Description;
            licensePlate = LicensePlate;

        }

    }
}
