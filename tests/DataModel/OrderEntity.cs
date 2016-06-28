﻿using System;
using System.Collections.Generic;

namespace Wheatech.ObjectMapper.UnitTests.DataModel
{
    public class OrderEntity
    {
        public Guid OrderId { get; set; }

        public string OrderCode { get; set; }

        public Guid CustomerId { get; set; }

        public string Address { get; set; }

        public ICollection<OrderItemEntity> Items { get; set; } 
    }
}
