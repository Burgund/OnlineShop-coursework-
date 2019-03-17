using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shopAPI.Models
{
    public class ProductModel
    {
        private string _name;
        private double _price;
        private int _id;

        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public int Id { get => _id; set => _id = value; }
    }
}