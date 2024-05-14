﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.Models
{
    public class Participant
    {
        [Key]
        public int ParticipantId {  get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        public string Score { get; set; }
        public string TimeTaken { get; set; }
    }
}
