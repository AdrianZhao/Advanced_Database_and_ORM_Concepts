using System.ComponentModel.DataAnnotations;

namespace AdvancedDatabaseAndORMConcepts.Models
{
    public enum Section
    {
        First,
        Second,
        Third
    }
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        [Range(1, 6, ErrorMessage = "Capacity must be between 1 and 6.")]
        public int Capacity { get; set; }
        public Section Section { get; set; }
    }
}