using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{
    public enum RoomType
    {
        Single,
        Double,
        Suite
    }
    public class Room
    {

        public int RoomNumber { get; }
        public RoomType RoomType { get; }
        
        public decimal NightlyRate { get; private set; }

        public bool inMaintenance { get; private set; }

        private readonly List<Reservation> _reservations = new();

        public IReadOnlyList<Reservation> Reservations => _reservations;
        public Reservation _reservation { get; private set; }

        public Room(int roomNumber, RoomType type, decimal roomRate)
        {
            RoomNumber = roomNumber;
            RoomType = type;
            this.NightlyRate = roomRate;
        }
        public void StartMaintenance()
        {
              inMaintenance = true;
        }
        public void EndMaintenance()
        {
             inMaintenance = false;
        }

        public void changeRoomRate(decimal newRate)
        {
            if (newRate <= 0)
            {
                throw new ArgumentException("Room rate cannot be negative.");
            }
            this.NightlyRate = newRate;
        }
        public bool CheckAvailability(DateTime checkIn, DateTime checkOut)
        {
            // overlap if checkIn < existing.CheckOutDate && checkOut > existing.CheckInDate
            foreach (var item in _reservations)
            {
                if (checkIn < item.CheckOutDate && checkOut > item.CheckInDate)
                    return false; // not available
            }

            return true; // available
        }
        internal void RegisterReservation(Reservation reservation)
        {
            _reservations.Add(reservation);
        }
    }
}
