﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NHLTeams.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Abbrev { get; set; }
        public string Fullname { get; set; }

    }
}
