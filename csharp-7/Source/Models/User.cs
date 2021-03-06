﻿using System;
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
        public int Id { get; set; }

        [Column("full_name")]
        [MaxLength(100)]
        [Required]
        public String FullName { get; set; }

        [Column("email")]
        [StringLength(100)]
        [Required]
        public String Email { get; set; }

        [Column("nickname")]
        [MaxLength(50)]
        [Required]
        public String Nickname { get; set; }

        [Column("password")]
        [MaxLength(255)]
        [Required]
        public String Password { get; set; }

        [Column("created_at")]
        [Timestamp]
        [Required]
        public DateTime CreatedAt { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<Submission> Submissions { get; set; }
    }
}
