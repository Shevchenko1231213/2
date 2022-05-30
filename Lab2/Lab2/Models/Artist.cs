using System;

namespace Lab2.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public byte Experience { get; set; }
    }
}
