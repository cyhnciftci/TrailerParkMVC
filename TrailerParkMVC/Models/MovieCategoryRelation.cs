﻿using System;
using System.Collections.Generic;

namespace TrailerParkMVC.Models
{
    public partial class MovieCategoryRelation
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CategoryId { get; set; }
    }
}
