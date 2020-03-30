﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.model
{
   public class hospdata
    {
        [Required]
        public int hospitalId { get; set; }
        [Required]
        public string hospitalName { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
