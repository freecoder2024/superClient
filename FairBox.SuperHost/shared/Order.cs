﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairBox.SuperHost.shared
{
    public class Order
    {
        public Guid OrderId { get; set; } = Guid.NewGuid();
        public string CustomerName { get; set; }
        public string Country { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public OrderType OrderType { get; set; }
        public decimal GrossValue { get; set; }
        public decimal NetValue { get => GrossValue * (1 - (DiscountPercentage / 100)); }
        public decimal DiscountPercentage { get; set; }


        public static List<Order> GetOrders()
        {
            var orders = new List<Order>();
            orders.Add(new Order { CustomerName = "Odio Corporation", Country = "Sweden", OrderDate = DateTimeOffset.Now.AddDays(-12), GrossValue = 34531, DiscountPercentage = 21, OrderType = OrderType.Contract });
            orders.Add(new Order { CustomerName = "Odio Corporation", Country = "Sweden", OrderDate = DateTimeOffset.Now.AddDays(-100), GrossValue = 2800, DiscountPercentage = 12, OrderType = OrderType.Mail });
            orders.Add(new Order { CustomerName = "Odio Corporation", Country = "Sweden", OrderDate = DateTimeOffset.Now.AddDays(-128), GrossValue = 12532, DiscountPercentage = 24, OrderType = OrderType.Contract });
            orders.Add(new Order { CustomerName = "Odio Corporation", Country = "Sweden", OrderDate = DateTimeOffset.Now.AddDays(-232), GrossValue = 1400, DiscountPercentage = 65, OrderType = OrderType.Mail });
            orders.Add(new Order { CustomerName = "Odio Corporation", Country = "Sweden", OrderDate = DateTimeOffset.Now.AddDays(-321), GrossValue = 22000, DiscountPercentage = 10, OrderType = OrderType.Contract });
            orders.Add(new Order { CustomerName = "Odio Corporation", Country = "Sweden", OrderDate = DateTimeOffset.Now.AddDays(-400), GrossValue = 3000, DiscountPercentage = 17, OrderType = OrderType.Web });

            orders.Add(new Order { CustomerName = "Nascetur AB", Country = "Sweden", OrderDate = DateTimeOffset.Now.AddDays(-17), GrossValue = 2134, DiscountPercentage = 10, OrderType = OrderType.Phone });
            orders.Add(new Order { CustomerName = "Nascetur AB", Country = "Sweden", OrderDate = DateTimeOffset.Now.AddDays(-27), GrossValue = 11345, DiscountPercentage = 12, OrderType = OrderType.Phone });
            orders.Add(new Order { CustomerName = "Nascetur AB", Country = "Sweden", OrderDate = DateTimeOffset.Now.AddDays(-124), GrossValue = 63400, DiscountPercentage = 79, OrderType = OrderType.Mail });
            orders.Add(new Order { CustomerName = "Nascetur AB", Country = "Sweden", OrderDate = DateTimeOffset.Now.AddDays(-299), GrossValue = 1235, DiscountPercentage = 12, OrderType = OrderType.Mail });
            orders.Add(new Order { CustomerName = "Nascetur AB", Country = "Sweden", OrderDate = DateTimeOffset.Now.AddDays(-372), GrossValue = 44000, DiscountPercentage = 11, OrderType = OrderType.Phone });
            orders.Add(new Order { CustomerName = "Nascetur AB", Country = "Sweden", OrderDate = DateTimeOffset.Now.AddDays(-410), GrossValue = 17000, DiscountPercentage = 5, OrderType = OrderType.Phone });

            orders.Add(new Order { CustomerName = "Justo Eu Institute", Country = "Spain", OrderDate = DateTimeOffset.Now.AddDays(-10), GrossValue = 12000, DiscountPercentage = 23, OrderType = OrderType.Mail });
            orders.Add(new Order { CustomerName = "Justo Eu Institute", Country = "Spain", OrderDate = DateTimeOffset.Now.AddDays(-13), GrossValue = 92800, DiscountPercentage = 48, OrderType = OrderType.Mail });
            orders.Add(new Order { CustomerName = "Justo Eu Institute", Country = "Spain", OrderDate = DateTimeOffset.Now.AddDays(-45), GrossValue = 12532, DiscountPercentage = 24, OrderType = OrderType.Web });
            orders.Add(new Order { CustomerName = "Justo Eu Institute", Country = "Spain", OrderDate = DateTimeOffset.Now.AddDays(-60), GrossValue = 1400, DiscountPercentage = 12, OrderType = OrderType.Mail });
            orders.Add(new Order { CustomerName = "Justo Eu Institute", Country = "Spain", OrderDate = DateTimeOffset.Now.AddDays(-150), GrossValue = 22000, DiscountPercentage = 10, OrderType = OrderType.Web });
            orders.Add(new Order { CustomerName = "Justo Eu Institute", Country = "Spain", OrderDate = DateTimeOffset.Now.AddDays(-200), GrossValue = 3000, DiscountPercentage = 17, OrderType = OrderType.Web });

            orders.Add(new Order { CustomerName = "Ani Vent", Country = "France", OrderDate = DateTimeOffset.Now.AddDays(-17), GrossValue = 2134, DiscountPercentage = 34, OrderType = OrderType.Phone });
            orders.Add(new Order { CustomerName = "Ani Vent", Country = "France", OrderDate = DateTimeOffset.Now.AddDays(-27), GrossValue = 11345, DiscountPercentage = 12, OrderType = OrderType.Phone });
            orders.Add(new Order { CustomerName = "Ani Vent", Country = "France", OrderDate = DateTimeOffset.Now.AddDays(-124), GrossValue = 17002, DiscountPercentage = 32, OrderType = OrderType.Mail });
            orders.Add(new Order { CustomerName = "Cali Inc", Country = "France", OrderDate = DateTimeOffset.Now.AddDays(-10), GrossValue = 77000, DiscountPercentage = 17, OrderType = OrderType.Web });
            orders.Add(new Order { CustomerName = "Cali Inc", Country = "France", OrderDate = DateTimeOffset.Now.AddDays(-110), GrossValue = 120000, DiscountPercentage = 23, OrderType = OrderType.Web });
            orders.Add(new Order { CustomerName = "Cali Inc", Country = "France", OrderDate = DateTimeOffset.Now.AddDays(-243), GrossValue = 44000, DiscountPercentage = 8, OrderType = OrderType.Web });


            orders.Add(new Order { CustomerName = "Chart Inc", Country = "Brazil", OrderDate = DateTimeOffset.Now.AddDays(-11), GrossValue = 2345, DiscountPercentage = 11, OrderType = OrderType.Phone });
            orders.Add(new Order { CustomerName = "Chart Inc", Country = "Brazil", OrderDate = DateTimeOffset.Now.AddDays(-14), GrossValue = 34567, DiscountPercentage = 22, OrderType = OrderType.Phone });
            orders.Add(new Order { CustomerName = "Chart Inc", Country = "Brazil", OrderDate = DateTimeOffset.Now.AddDays(-121), GrossValue = 45662, DiscountPercentage = 23, OrderType = OrderType.Mail });
            orders.Add(new Order { CustomerName = "Chart Inc", Country = "Brazil", OrderDate = DateTimeOffset.Now.AddDays(-11), GrossValue = 66000, DiscountPercentage = 11, OrderType = OrderType.Web });
            orders.Add(new Order { CustomerName = "Chart Inc", Country = "Brazil", OrderDate = DateTimeOffset.Now.AddDays(-90), GrossValue = 10000, DiscountPercentage = 8, OrderType = OrderType.Web });
            orders.Add(new Order { CustomerName = "Chart Inc", Country = "Brazil", OrderDate = DateTimeOffset.Now.AddDays(-123), GrossValue = 69000, DiscountPercentage = 25, OrderType = OrderType.Web });


            return orders;
        }

    }

    public enum OrderType
    {
        Web, Contract, Mail, Phone
    }
}
