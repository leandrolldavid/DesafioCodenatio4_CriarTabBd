using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("acceleration")]
    public class Acceleration
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("name")]
        [StringLength(100)]
        [Required]
        public String Name { get; set; }

        [Column("slug")]
        [StringLength(50)]
        [Required]
        public String Slug { get; set; }

        [Column("Created_at")]
        [Timestamp]
        [Required]
        public DateTime Created_at { get; set; }

        [Column("chanllenge_id")]
        [ForeignKey("Challenge")]
        [Required]
        public int Chanllege_Id { get; set; }
        public Challenge Challenge { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
    }
}
