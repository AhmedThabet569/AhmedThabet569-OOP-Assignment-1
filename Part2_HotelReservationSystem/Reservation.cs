using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem
{

    public enum ReservationStatus
    {
        Pending,
        Confirmed,
        CheckedIn,
        CheckedOut,
        Cancelled
    }
    public class Reservation
    {
        public int ReservationId { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public Guest Guest { get; }
        public Room Room { get; }

        public ReservationStatus Status { get; private set; }

        public decimal totalCost
        {
            get
            {
                TimeSpan duration = CheckOutDate - CheckInDate;
                return (decimal)duration.TotalDays * Room.NightlyRate;
            }
        }
        public Reservation(int reservationId, DateTime checkInDate, DateTime checkOutDate, Guest guest, Room room)
        {
            
            if (checkOutDate <= checkInDate)
            {
                throw new ArgumentException("Check-out date must be after check-in date.");
            }
            if (room.inMaintenance)
            {
                throw new InvalidOperationException("Cannot add reservation. Room is under maintenance.");
            }
            if(guest == null)
            {
                throw new ArgumentNullException(nameof(guest), "Guest cannot be null.");
            }
            if(room == null)
            {
                throw new ArgumentNullException(nameof(room), "Room cannot be null.");
            }
            if(room.inMaintenance)
            {
                throw new InvalidOperationException("Cannot add reservation. Room is under maintenance.");
            }
            ReservationId = reservationId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Guest = guest;
            Room = room;
            Status = ReservationStatus.Pending;
        }

        public void checkInReservation()
        {
            if (Status != ReservationStatus.Confirmed)
            {
                throw new InvalidOperationException("Cannot check in. Reservation is not confirmed.");
            }
            Status = ReservationStatus.CheckedIn;

        }
        public void confirmReservation()
        {
            if (Status != ReservationStatus.Pending)
            {
                throw new InvalidOperationException("Only pending reservations can be confirmed.");
            }
            Status = ReservationStatus.Confirmed;
        }
        public void checkOutReservation()
        {
            if (Status != ReservationStatus.CheckedIn)
            {
                throw new InvalidOperationException("Cannot check out. Reservation is not checked in");

            }
            Status = ReservationStatus.CheckedOut;
        }
        public void cancelReservation()
        {
            if (Status != ReservationStatus.Pending &&
        Status != ReservationStatus.Confirmed)
            {
                throw new InvalidOperationException(
                    "Only pending or confirmed reservations can be cancelled.");
            }

            Status = ReservationStatus.Cancelled;
        }
    }
}
