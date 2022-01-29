﻿using GloboTicket.TikectManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TikectManagement.Domain.Entities
{
    public class Order : AuditableEntity
    {
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public int OrderTotal { get; set; }
        public string OrderPlaced { get; set; }
        public bool OrderPaid { get; set; }
    }
}
