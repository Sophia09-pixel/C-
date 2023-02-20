using System;

namespace Course.Entities
{
    class Reservetion
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservetion()
        {

        }

        public Reservetion(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room: "
                + RoomNumber
                + ", checkin: "
                + CheckIn.ToString("(dd/mm/yyyy)")
                + ", checkout: "
                + CheckOut.ToString("dd/mm/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
