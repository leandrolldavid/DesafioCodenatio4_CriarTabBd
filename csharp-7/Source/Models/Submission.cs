using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    [Table("submission")]
    public class Submission
    {
        [Column("score")]
        [Required]
        public decimal Score { get; set; }

        [Column("created_at")]
        [Timestamp]
        [Required]
        public DateTime Created_at { get; set; }

        [Column("challenge_id")]
        [ForeignKey("Challenge")]
        [Required]
        public int Challenge_id { get; set; }
        public Challenge Challenge { get; set; }

        [Column("user_id")]
        [ForeignKey("User")]
        [Required]
        public int User_id { get; set; }
        public User User { get; set; }
    }
}
