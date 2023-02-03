using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Orders.Queries.GetOrderList
{
    public class OrdersVm
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public decimal Totalprice { get; set; }

        //BillingAddress
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? Addressline { get; set; }
        public string? Country { get; set; } 
        public string? State { get; set; }
        public string? ZipCode { get; set; }

        //Payment
        public string? CradName { get; set; }
        public string? CardNumber { get; set; }
        public string? Expiration { get; set; }
        public string? CVV { get; set; }
        public int PaymentMethod { get; set; }
    }
}
