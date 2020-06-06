using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codenation.Challenge.Models
{
    [Table("candidate")]
    public class Candidate
    {
        [Column("status")]
        [Required]
        public int Status { get; set; }

        [Column("created_at")]
        [Timestamp]
        [Required]
        public DateTime Created_at { get; set; }

        [Column("user_id")]
        [ForeignKey("User")]
        [Required]
        public int User_id { get; set; }
        public User User { get; set; }

        [Column("acceleration_id")]
        [ForeignKey("Acceleration")]
        [Required]
        public int Acceleration_id { get; set; }
        public Acceleration Acceleration { get; set; }

        [Column("company_id")]
        [ForeignKey("Company")]
        [Required]
        public int Company_id { get; set; }
        public Company Company { get; set; }
    }
}
