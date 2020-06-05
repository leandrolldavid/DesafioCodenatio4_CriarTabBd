using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    [Table("acceleration")]
    public class Acceleration
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
       
        [Column("chanllenge_id")]
        [Required]
        public int ChanllegeId { get; set; }

        [Column("Created_at", TypeName = "timestamp")]
        [Required]
        public DateTime Created_at { get; set; }

        public Challenge Challenge { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}
