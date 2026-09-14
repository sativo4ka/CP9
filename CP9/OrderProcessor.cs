using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CP9
{
    public class OrderProcessor
    {
        public (int Total, int Success, int Skipped) ProcessOrders(IEnumerable<string> rawOrders)
        {
            int total = 0;
            int success = 0;
            int skipped = 0;

            foreach (var rawOrder in rawOrders)
            {
                total++;
                try
                {
                    var parts = rawOrder.Split(';');

                    if (parts.Length != 3 ||
                        !decimal.TryParse(parts[1], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal price) ||
                        !int.TryParse(parts[2], out int count))
                    {
                        Console.WriteLine($"Строка: \"{rawOrder}\" -> пропущен, предупреждение о формате, без исключения");
                        skipped++;
                        continue;
                    }

                    string orderId = parts[0];

                    if (price < 0 || count < 0)
                    {
                        throw new OrderProcessingException($"Цена ({price}) или количество ({count}) не могут быть отрицательными", orderId);
                    }

                    Console.WriteLine($"Строка: \"{rawOrder}\" -> обработан успешно");
                    success++;
                }
                catch (OrderProcessingException ex) when (!string.IsNullOrEmpty(ex.OrderId))
                {
                    Console.WriteLine($"Строка: \"{rawOrder}\" -> OrderProcessingException, пойман через when, пропущен");
                    skipped++;
                }
            }

            Console.WriteLine($"итог: Обработано: {total}, успешно: {success}, пропущено: {skipped}");
            return (total, success, skipped);
        }
    }
}
