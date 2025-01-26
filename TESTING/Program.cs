using System;
using System.Collections.Generic;
using System.IO;

namespace TESTING
{
    class Program
    {
        static Dictionary<string, Flight> Flights = new Dictionary<string, Flight>();

        static void Main(string[] args)
        {
            string filePath = @"C:\Users\petro\Downloads\flights (1).csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Error: File not found at {filePath}");
                return;
            }

            LoadFlightsFromCsv(filePath);
            DisplayAllFlights(Flights);
        }

        static void LoadFlightsFromCsv(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    string header = reader.ReadLine(); // Skip header line

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        string[] fields = line.Split(',');

                        if (fields.Length < 5)
                        {
                            Console.WriteLine($"Skipping invalid line: {line}");
                            continue;
                        }

                        string flightNumber = fields[0].Trim();
                        string origin = fields[1].Trim();
                        string destination = fields[2].Trim();

                        if (!DateTime.TryParse(fields[3].Trim(), out DateTime expectedTime))
                        {
                            Console.WriteLine($"Invalid date format for flight {flightNumber}: {fields[3]}");
                            continue;
                        }

                        string status = fields.Length > 4 ? fields[4].Trim() : "Unknown";
                        string type = fields.Length > 5 ? fields[5].Trim() : "NORM";
                        double requestFee = (fields.Length > 6 && double.TryParse(fields[6].Trim(), out double fee)) ? fee : 0;

                        Flight flight;

                        switch (type)
                        {
                            case "NORM":
                                flight = new NORMFlight(flightNumber, origin, destination, expectedTime, status);
                                break;
                            case "LWTT":
                                flight = new LWTTFlight(flightNumber, origin, destination, expectedTime, status, requestFee);
                                break;
                            case "CFFT":
                                flight = new CFFTFlight(flightNumber, origin, destination, expectedTime, status, requestFee);
                                break;
                            case "DDJB":
                                flight = new DDJBFlight(flightNumber, origin, destination, expectedTime, status, requestFee);
                                break;
                            default:
                                Console.WriteLine($"Unknown flight type: {type}. Skipping...");
                                continue;
                        }

                        if (Flights.ContainsKey(flightNumber))
                        {
                            Console.WriteLine($"Duplicate flight number found: {flightNumber}. Skipping...");
                            continue;
                        }

                        Flights.Add(flightNumber, flight);
                    }
                }

                Console.WriteLine("Flights loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading flights: {ex.Message}");
            }
            static void DisplayAllFlights(Dictionary<string, Flight> Flight)
            {
                Console.WriteLine("---- Flights Information ----");
                foreach (var flight in Flights.Values)
                {
                    Console.WriteLine(flight);
                }
            }
        }
    }
}