using Aula152.Entities;
using System;

namespace Aula152
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

            Console.WriteLine("Reservation: " + reservation.ToString());
        }
    }
}