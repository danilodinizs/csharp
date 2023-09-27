//using exercicios;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace exercicios
//{
//    internal class Reservation
//    {
//        public int RoomNumber { get; set; }
//        public DateTime CheckIn { get; set; }
//        public DateTime CheckOut { get; set; }

//        public Reservation() { 
//        }

//        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
//        {
//            if (checkOut <= checkIn)
//            {
//                throw new DomainException("Check-out date must be after check-in date");
//            }
//            RoomNumber = roomNumber;
//            CheckIn = checkIn;
//            CheckOut = checkOut;
//        }

//        public int Duration()
//        {
//            TimeSpan duration = CheckOut.Subtract(CheckIn);
//            return (int)duration.TotalDays;
//        }

//        public void UpdateDates(DateTime checkIn, DateTime checkOut)
//        {   
//            if (checkIn < CheckIn || checkOut < CheckOut)
//            {
//                throw new DomainException("Reservation dates for update must be future dates");
//            }
//            if (checkOut <= checkIn)
//            {
//                throw new DomainException("Check-out date must be after check-in date");
//            }

//            CheckIn = checkIn;
//            CheckOut = checkOut;
//        }

//        public override string ToString()
//        {
//            return "Room "
//                + RoomNumber
//                + ", check-in: "
//                + CheckIn.ToString("dd/MM/yyyy")
//                + ", check-out: "
//                + CheckOut.ToString("dd/MM/yyyy")
//                + ", "
//                + Duration()
//                + " nights"; 
//        }

        
//    }
//}

//MAIN:

//try
//{
//    Console.Write("Room number: ");
//    int roomNumber = int.Parse(Console.ReadLine());
//    Console.Write("Check-in date (dd/MM/yyyy): ");
//    DateTime checkIn = DateTime.Parse(Console.ReadLine());
//    Console.Write("Check-out date (dd/MM/yyyy): ");
//    DateTime checkOut = DateTime.Parse(Console.ReadLine());

//    Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

//    Console.WriteLine("Reservation: " + reservation);

//    Console.WriteLine();
//    Console.WriteLine("Enter data to update the reservation: ");
//    Console.Write("Check-in date (dd/MM/yyyy): ");
//    checkIn = DateTime.Parse(Console.ReadLine());
//    Console.Write("Check-out data (dd/MM/yyyy): ");
//    checkOut = DateTime.Parse(Console.ReadLine());

//    reservation.UpdateDates(checkIn, checkOut);

//    Console.WriteLine("Reservation: " + reservation);
//}
//catch (DomainException e)
//{
//    Console.WriteLine("Error in reservation: " + e.Message);
//}
//catch (FormatException e)
//{
//    Console.WriteLine("Format error: " + e.Message);
//}
//catch (Exception e)
//{
//    Console.WriteLine("Unexpected error: " + e.Message);
//}