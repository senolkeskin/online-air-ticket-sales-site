﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}
