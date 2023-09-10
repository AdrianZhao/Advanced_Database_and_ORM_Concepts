using System.ComponentModel.DataAnnotations;

namespace AdvancedDatabaseAndORMConcepts.Models
{
    public class Client
    {
        public int ID { get; set; }

        [Required (ErrorMessage = "Last Name is required.")]
        [StringLength (25, MinimumLength = 3, ErrorMessage = "Last Name is between 3 and 25 characters.")]
        public string LastName { get; set; }

        [StringLength (25, MinimumLength = 3, ErrorMessage = "First Name is between 3 and 25 characters.")]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "Phone Number is required.")]
        [RegularExpression (@"^\d{10}$", ErrorMessage = "Phone Number must be a 10 digits number.")]
        public string PhoneNumber { get; set; }
    }
}