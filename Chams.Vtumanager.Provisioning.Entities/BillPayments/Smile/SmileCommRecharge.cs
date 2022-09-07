﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chams.Vtumanager.Provisioning.Entities.BillPayments.Smile
{
    public class SmileCommRechargeRequest
    {

        public SmileRechargeDetails details { get; set; }
        public string id { get; set; }
        public string paymentCollectorId { get; set; }
        public string paymentMethod { get; set; }
        public string serviceId { get; set; }

        public class SmileRechargeDetails
        {
            public int customerAccountId { get; set; }
            public int amount { get; set; }
        }

    }
}
