﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entities.Base
{
    public class EntityBase
    {
        public EntityBase()
        {

        }

        [Key]
        public String Id { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
