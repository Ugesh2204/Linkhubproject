﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LHBOL
{
    [Table("LHUrl")]
    public class LHUrl
    {
        [Key]
        public int UrlId { get; set; }
        public string UrlTitle { get; set; }
        public string LHUrlName { get; set; }
        public string Description { get; set; }
        public bool IsApproved { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        //Object of category
        public Category Category { get; set; }

        [ForeignKey("Category")]
        public string UserId { get; set; }

        public User User { get; set; }


    }
}
