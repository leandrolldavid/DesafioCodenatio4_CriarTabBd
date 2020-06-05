using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models

{
    [Table("user")]
    public class User
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("full_name")]
        [StringLength(100)]
        [Required]
        public String Full_name { get; set; }

        [Column("email")]
        [StringLength(100)]
        [Required]
        public String Email { get; set; }

        [Column("nickname")]
        [StringLength(50)]
        [Required]
        public String Nickname { get; set; }

        [Column("password")]
        [StringLength(255)]
        [Required]
        public String Password { get; set; }

        [Column("Created_at")]
        [Timestamp]
        [Required]
        public DateTime Created_at { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<Submission> Submissions { get; set; }
    }
}
