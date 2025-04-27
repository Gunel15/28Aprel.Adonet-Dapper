using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _28April.AdoNet_Dapper.Constants;
using _28April.AdoNet_Dapper.Models;
using _28April.AdoNet_Dapper.Repositories.Abstractions;
using Dapper;
using Microsoft.Data.SqlClient;

namespace _28April.AdoNet_Dapper.Repositories.Implementations
{
    class ProductRepository : IProductRepository<Product>
    {
        private SqlConnection _connection { get => new(ConnectionString.SqlConnectionString); }
        public ProductRepository()
        {
            
        }
        public void Add(Product entity)
        {
            using var db = _connection;
            db.Execute("insert into products values(@Name,@Price,@CategoryId)", entity);
        }

        public void Delete(int id)
        {

            using var db = _connection;
            db.Execute($"delete products where Id={id} ");
        }

        public List<Product> GetAll()
        {

            using var db = _connection;
            var list=db.Query<Product>("Select*from Products").ToList();
            return list ?? new();
        }

        public Product GetById(int id)
        {
            using var db = _connection;
            var product = db.QuerySingleOrDefault<Product>($"select*from products where Id={id}");
            return product;
        }

        public void Update(int id, Product entity)
        {
            using var db = _connection;
            db.Execute($"update products set Name=@Name,Price=@Price where Id={id} ",entity);
        }
    }
}
