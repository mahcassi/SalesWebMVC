using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name; 
        }

        public void AddSaller(Seller seller)
        {
            Sellers.Add(seller);
        }

        // Somando as vendas nesse periodo de data de todos os vendedores do departamento
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
