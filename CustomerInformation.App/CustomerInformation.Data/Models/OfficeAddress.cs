﻿using System.Collections.Generic;

namespace CustomerInformation.Data.Models
{
    public class OfficeAddress
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public ICollection<OfficePhone> OfficePhones { get; set; }
    }
}
