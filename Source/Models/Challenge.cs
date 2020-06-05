using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Codenation.Challenge.Models
{ 
    [Table("challenge")]
    public class Challenge
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("name", TypeName = "varchar(100)")]
        [Required]
        public String Name { get; set; }

        [Column("slug", TypeName = "varchar(50)")]
        [Required]
        public String Slug { get; set; }

        [Column("Created_at", TypeName = "timestamp")]
        [Required]
        public DateTime Created_at { get; set; }

        public ICollection<Acceleration> Accelerations { get; set; }
        public ICollection<Submission> Submissions { get; set; }
    }
}
