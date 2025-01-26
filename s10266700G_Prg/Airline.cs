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
            get { return Flights; }
            set { flights = value; }
        }
        public Airline(string n, string c, Dictionary<String, Flight> f)
        {
            name = n;
            code = c;
            flights = f;
        }
        public bool AddFlight(Flight value)
        {
            if (value == null)
            {
                return false;
            }
            else
            {
                flights.Add(value.FlightNumber, value);
                return true;
            }
        }
        public double CalculateFees()
        {
            return 1;
        }
        public bool RemoveFlight(Flight flight)
        {
            if (Flights.ContainsKey(flight.FlightNumber))
            {
                Flights.Remove(flight.FlightNumber, flight);
                return true;
            }
            else
            { 
                return false;
            }
        } 
        public override string ToString()
        {
            return "Airline: " + Name + " (" + Code + ")";
        }
    }
}  
