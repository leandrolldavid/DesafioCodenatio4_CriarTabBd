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
        //[Column("user_id")]
        [ForeignKey("user_id")]
        [Required]
        public int User_Id { get; set; }

        [ForeignKey("acceleration_id")]
        [Required]
        public int Acceleration_Id { get; set; }
       
        [ForeignKey("Company_id")]
        [Required]
        public int Company_Id { get; set; }

        [Column("status")]
        [Required]
        public int Status { get; set; }

        [Column("Created_at", TypeName = "timestamp")]
        [Required]
        public DateTime Created_at { get; set; }

        public User User { get; set; }
        public Acceleration Acceleration { get; set; }
        public Company Company { get; set; }
    }
}
