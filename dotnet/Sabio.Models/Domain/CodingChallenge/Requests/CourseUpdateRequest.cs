﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabio.Models.Domain.CodingChallenge.Requests
{
    public class CourseUpdateRequest : CourseAddRequest, IModelIdentifier
    {

        public int Id { get; set; }

    }
}
