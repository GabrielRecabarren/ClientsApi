﻿namespace ClientsAPI
{
    public class Clients
    {

        public int Id { get; set; }
        public string Name { get; set; }= string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int CountryCode { get; set; }
    }
}
