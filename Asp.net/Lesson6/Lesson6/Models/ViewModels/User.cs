using Lesson6.Models.ModelMetadataTypes;
using Microsoft.AspNetCore.Mvc;

namespace Lesson6.Models.ViewModels
{
    //[ModelMetadataType(typeof(UserValidator))]
    public class User
    {
        public string Email { get; set; }

        public string Pass { get; set; }

        public string Confirm { get; set; }
    }
}
