using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{
    public class Guest
    {

        public string FullName { get; }
        public int GuestId { get; }
        public string PhoneNumber { get; }
        private List<Reservation> _reservations = new();

        public IReadOnlyList<Reservation> Reservations => _reservations;

        public Guest(string name, int id, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }
            if (id <= 0)
            {
                throw new ArgumentException("ID must be a positive integer.");
            }
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentException("Phone number cannot be null or empty.");
            }
            this.FullName = name;
            this.GuestId = id;
            this.PhoneNumber = phoneNumber; 
        }

        public void AddReservation(Reservation reservation)
        {
            if (reservation == null)
                throw new ArgumentNullException(nameof(reservation), "Reservation cannot be null.");
            if(!reservation.Room.CheckAvailability(reservation.CheckInDate,reservation.CheckOutDate))
            {
               throw new InvalidOperationException("The room is not available for the specified dates.");
            }
            _reservations.Add(reservation);
            reservation.Room.RegisterReservation(reservation);
        }

    }
}


