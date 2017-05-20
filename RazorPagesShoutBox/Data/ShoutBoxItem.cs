using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesShoutBox.Data
{
    public class ShoutBoxItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime? Time { get; set; }

        [Required]       
        public string Name { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
