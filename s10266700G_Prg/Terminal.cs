using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s10266700G_Prg
{
    internal class Terminal
    {
        private string terminalName;
        public string TerminalName
        {
            get { return terminalName; }
            set { terminalName = value; }
        }
        private Dictionary<String, Airline> airlines;
        public Dictionary<String, Airline> Airlines
        {
            get { return airlines; }
            set { airlines = value; }
        }
        private Dictionary<String, Flight> flights;
        public Dictionary<String, Flight> Flights
        {
            get { return flights; }
            set { flights = value; }
        }
        private Dictionary<String, BoardingGate> boardingGates;
        public Dictionary<String, BoardingGate> BoardingGates
        {
            get { return boardingGates; }
            set { boardingGates = value; }
        }
        private Dictionary<String, double> gateFees;
        public Dictionary<String, double> GateFees
        {
            get { return gateFees; }
            set { gateFees = value; }
        }
        public Terminal(string terminalName, Dictionary<String, Airline> airlines, Dictionary<String, Flight> flights, Dictionary<String, BoardingGate> boardingGates,Dictionary<String, double> gatefees)
        {
            TerminalName = terminalName;
            Airlines = airlines;
            Flights = flights;
            BoardingGates = boardingGates;
            GateFees = gateFees;
        }
        public bool AddAirline(Airline)
        {
            
        }
        public bool AddBoardingGate(BoardingGate)
        {

        }
        

        }
    }

    
   


