using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}
