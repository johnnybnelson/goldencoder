﻿using Sabio.Models.Domain.Skills;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabio.Models.Requests.Jobs
{
    public class JobAddRequest
    {

        [StringLength(100)]  //allowable range
        public string Title { get; set; }

        [StringLength(500)]  //allowable range
        public string Description { get; set; }

        [StringLength(256)]  //allowable range
        public string Summary { get; set; }

        [StringLength(10)]  //allowable range
        public string Pay { get; set; }

        [StringLength(50)]  //allowable range
        public string Slug { get; set; }

        [StringLength(10)]  //allowable range
        public string StatusId { get; set; }

        public int UserId { get; set; }

        public int TechCompanyId { get; set; }

        public List<string> Skills { get; set; }

    }
}
