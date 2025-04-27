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
    class CategoryRepository:ICategoryRepository<Category>
    {
        private SqlConnection _connection { get => new(ConnectionString.SqlConnectionString); }
        public CategoryRepository()
        {

        }

        public void Add(Category entity)
        {
            using var db = _connection;
            db.Execute("insert into categogies values(@Name)", entity);
        }

        public void Update(int id, Category entity)
        {
            using var db = _connection;
            db.Execute($"update categories set Name=@Name where Id={id} ", entity);
        }

        public void Delete(int id)
        {
            using var db = _connection;
            db.Execute($"delete categories where Id={id} ");
        }

        public List<Category> GetAll()
        {
            using var db = _connection;
            var list = db.Query<Category>("Select*from categories").ToList();
            return list ?? new();
        }

        public Category GetById(int id)
        {
            using var db = _connection;
            var category = db.QuerySingleOrDefault<Category>($"select*from categories where Id={id}");
            return category;
        }
    }
}
