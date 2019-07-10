using System.ComponentModel.DataAnnotations;

namespace Job.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}