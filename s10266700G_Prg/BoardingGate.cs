using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s10266700G_Prg
{
    internal class BoardingGate
    {
        private string getName;
        public string GetName
        {
            get { return getName; }
            set { getName = value; }
        }

        private bool supportsCFFT;
        public bool SupportsCFFT
        {
            get { return supportsCFFT; }
            set { supportsCFFT = value; }
        }
        private bool supportsDDJB;
        public bool SupportsDDJB
        {
            get { return supportsDDJB; }
            set { supportsDDJB = value; }
        }
        private bool supportsWTT;
        public bool SupportsWTT
        {
            get { return supportsWTT; }
            set { supportsWTT = value; }


        }
        private Flight flight;
        public Flight Flight
        {
            get { return flight; }
            set { flight = value; }
        }
        public BoardingGate() { }
        public BoardingGate(string getName, bool supportsCFFT, bool supportsDDJB, bool supportsWTT, Flight flight)
        {
            GetName = getName;
            SupportsCFFT = supportsCFFT;
            SupportsDDJB = supportsDDJB;
            SupportsWTT = supportsWTT;
            Flight = flight;
        }
        public void CalculateFees()
        {

        }
        public override string ToString()
        {
            return "get"
        }

    }
}
