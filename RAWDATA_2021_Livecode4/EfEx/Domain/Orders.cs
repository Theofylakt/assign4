﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfEx.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        //public DateTime shippeddate { get; set; }
        public int Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipCity { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, OrderDate = {OrderDate}, RequiredDate = {RequiredDate}, Freight = {Freight}, ShipName = {ShipName}, ShipCity = {ShipCity}";
        }



    }
}
