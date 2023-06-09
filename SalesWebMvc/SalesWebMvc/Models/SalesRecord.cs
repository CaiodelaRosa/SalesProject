﻿using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Statusoperty { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus statusoperty, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Statusoperty = statusoperty;
            Seller = seller;
        }
    }
}
