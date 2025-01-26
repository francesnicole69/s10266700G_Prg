using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s10266700G_Prg
{
    internal class Airline
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string code;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        private Dictionary<String, Flight> flights;
        public Dictionary<String, Flight> Flights
        {
            get { return Flights}
            set { flights = value; }
        }
        public Airline(string name, string code, Dictionary<String, Flight> Flights)
        {
            Name = name;
            Code = code;
            Flights = flights;
        }
        public bool AddFlight(flight)
        {

        }
        public double CalculateFees()
        {

        }
        public bool RemoveFlight(Flight)
        {

        }
        public override string ToString() {
        }
    }
}  
