﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Models
{
    public class DepartmentToAddOrUpdateDTO
    {
        public int? DepartmentId { get; set; }
       
        public string DepartmentName { get; set; }

        public bool IsDeleted { get; set; }
        
    }
}
