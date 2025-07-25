﻿namespace CafeApi.WebApi.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string NameSurname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime ReservationDate { get; set; }
        public string DateTime { get; set; }
        public int CountOfPeople { get; set; }
        public string Message { get; set; }
        public string ReservationStatus { get; set; }
    }
}
