using System;
using System.Collections.Generic;
using System.Globalization;

namespace CP9
{

    public class Program
    {
        public static void Main()
        {
            var processor = new OrderProcessor();
            var orders = new[] { "ORDER001;150.50;3", "плохая строка", "ORDER002;-10;1", "ORDER003;200;2" };
            processor.ProcessOrders(orders);
        }
    }
}