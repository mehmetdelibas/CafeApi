﻿namespace CafeApi.WebApi.DTOs.ContactDTOs
{
    public class CreateContactDTO
    {
        public string MapLocation { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OpenHours { get; set; }
    }
}
