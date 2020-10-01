﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesAPI.Models
{
    public class QuoteTag
    {
        [ForeignKey("TagId")]
        public Tag Tag { get; set; }
        [Key]
        public int TagId { get; set; }
        [ForeignKey("QuoteId")]
        public Quote Quote { get; set; }
        [Key]
        public int  QuoteId{ get; set; }
    }
}
