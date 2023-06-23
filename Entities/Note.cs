/*using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OrganizerApp.Entites
{
    [Table("Note")]
    public class Note
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public int? CategoryId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
    }
}*/