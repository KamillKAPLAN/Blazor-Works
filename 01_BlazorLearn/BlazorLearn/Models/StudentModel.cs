using System.ComponentModel.DataAnnotations;

namespace BlazorLearn.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }

        [Required (ErrorMessage = "İsim zorunlu...")]
        public string Name { get; set; }

        [Required (ErrorMessage ="Roll zorunlu...")]
        public string Roll { get; set; }
    }
}
