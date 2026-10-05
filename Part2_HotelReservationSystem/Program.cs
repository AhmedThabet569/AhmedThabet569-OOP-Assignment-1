namespace HotelSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room101 = new Room(
                101,
                RoomType.Double,
                200m
            );

            // 2. Create a guest
            Guest guest = new Guest(
                "Ahmed Ali",
                1,
                "0501234567"
            );

            // 3. Create a reservation
            Reservation reservation = new Reservation(
                1001,
                new DateTime(2026, 10, 10),
                new DateTime(2026, 10, 15),
                guest,
                room101
            );

            // 4. Add reservation to guest
            guest.AddReservation(reservation);

            Console.WriteLine("Reservation created successfully.");
            Console.WriteLine($"Guest: {guest.FullName}");
            Console.WriteLine($"Room: {reservation.Room.RoomNumber}");
            Console.WriteLine($"Check-in: {reservation.CheckInDate:d}");
            Console.WriteLine($"Check-out: {reservation.CheckOutDate:d}");
            Console.WriteLine($"Status: {reservation.Status}");
            Console.WriteLine($"Total Cost: {reservation.totalCost}");

            // 5. Confirm reservation
            reservation.confirmReservation();

            Console.WriteLine($"Status after confirmation: {reservation.Status}");

            // 6. Check in
            reservation.checkInReservation();

            Console.WriteLine($"Status after check-in: {reservation.Status}");

            // 7. Check out
            reservation.checkOutReservation();

            Console.WriteLine($"Status after check-out: {reservation.Status}");
            //        Room room102 = new Room(
            //    102,
            //    RoomType.Single,
            //    150m
            //);

            //        Guest guest1 = new Guest(
            //            "Ahmed",
            //            1,
            //            "0501111111"
            //        );

            //        Guest guest2 = new Guest(
            //            "Mohamed",
            //            2,
            //            "0502222222"
            //        );

            //        Reservation reservation1 = new Reservation(
            //            2001,
            //            new DateTime(2026, 10, 10),
            //            new DateTime(2026, 10, 15),
            //            guest1,
            //            room102
            //        );

            //        guest1.AddReservation(reservation1);

            //try
            //{
            //    Reservation reservation2 = new Reservation(
            //        2002,
            //        new DateTime(2026, 10, 12),
            //        new DateTime(2026, 10, 18),
            //        guest2,
            //        room102
            //    );

            //        guest2.AddReservation(reservation2);

            //    Console.WriteLine("Second reservation accepted.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Double booking rejected: {ex.Message}");
            //}

            //        }
        }
}


