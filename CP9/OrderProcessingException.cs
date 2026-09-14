using System;
using System.Collections.Generic;
using System.Text;

namespace CP9
{
    public class OrderProcessingException : Exception
    {
        public string? OrderId { get; }

        public OrderProcessingException(string message, string? orderId = null)
            : base(message)
        {
            OrderId = orderId;
        }
    }
}
