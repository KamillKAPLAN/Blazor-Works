using System.ComponentModel.DataAnnotations;

namespace PlannerApp.Shared.Models
{
    public class ToDoItemRequest
    {
        public string Id { get; set; }

        [Required (ErrorMessage = "Description zordunludur...")]
        [StringLength(200)]
        public string Description { get; set; }

        public string PlanId { get; set; }
    }
}
