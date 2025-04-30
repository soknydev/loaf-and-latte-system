using loaf_and_latte_system.Config;
using loaf_and_latte_system.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace loaf_and_latte_system.Repositories
{
    class ProductRepository
    {
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new();
            var conn = DatabaseConnection.GetInstance();
            conn.Open();

            string query = @"SELECT p.*, c.category_name 
                             FROM Products p
                             LEFT JOIN Categories c ON p.category_id = c.category_id
                             WHERE p.is_available = TRUE";

            using MySqlCommand cmd = new(query, conn);
            using MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                products.Add(new Product
                {
                    Name = reader.GetString("name"),
                    Description = reader.IsDBNull(reader.GetOrdinal("description")) ? "" : reader.GetString("description"),
                    Price = reader.GetDecimal("price"),
                    CategoryId = reader.IsDBNull(reader.GetOrdinal("category_id")) ? null : reader.GetInt32("category_id"),
                    ImagePath = reader.IsDBNull(reader.GetOrdinal("image_path")) ? null : reader.GetString("image_path"),
                    IsAvailable = reader.GetBoolean("is_available"),
                    StockLevel = reader.GetInt32("stock_level"),
                    
                });
            }

            conn.Close();
            return products;
        }
    }
}
