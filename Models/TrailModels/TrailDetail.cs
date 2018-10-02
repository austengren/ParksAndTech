﻿using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.TrailModels
{
    public class TrailDetail
    {
        [Required]
        public int TrailID { get; set; }

        [Required]
        public string TrailName { get; set; }

        [Required]
        public decimal TrailDistance { get; set; }

        [Required]
        public Difficulty TrailDifficulty { get; set; }

        [Required]
        public Condition TrailCondition { get; set; }

        [Required]
        public int ParkID { get; set; }
        public string ParkName { get; set; }

        public override string ToString() => TrailName;

        //public virtual Park Park { get; set; }
    }
}
