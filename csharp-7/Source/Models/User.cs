using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [Column("full_name", TypeName = "varchar(100)")]
        [Required]
        public String Full_name { get; set; }

        [Column("email", TypeName = "varchar(100)")]
        [Required]
        public String Email { get; set; }

        [Column("nickname", TypeName = "varchar(50)")]
        [Required]
        public String Nickname { get; set; }

        [Column("password", TypeName = "varchar(255)")]
        [Required]
        public String Password { get; set; }

        [Column("Created_at", TypeName = "timestamp")]
        [Required]
        public DateTime Created_at { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<Submission> Submissions { get; set; }
    }
}
