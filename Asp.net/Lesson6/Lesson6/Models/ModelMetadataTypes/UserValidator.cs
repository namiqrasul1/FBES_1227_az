using System.ComponentModel.DataAnnotations;

namespace Lesson6.Models.ModelMetadataTypes
{
    public class UserValidator
    {
        [EmailAddress(ErrorMessage = "Write valid email address")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Password must be greater than 6")]
        public string Pass { get; set; }
        [Compare("Pass")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }
    }
}
