﻿namespace CustomerInvoiceApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
