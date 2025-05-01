using loaf_and_latte_system.Config;
using loaf_and_latte_system.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace loaf_and_latte_system.Repositories
{
    class ProductRepository
    {

        public bool AddToCart(int employeeId, int productId, int quantity)
        {
            string checkQuery = @"
        SELECT quantity 
        FROM Cart 
        WHERE employee_id = @employeeId AND product_id = @productId AND is_paid = FALSE";

            string updateQuery = @"
        UPDATE Cart 
        SET quantity = quantity + @quantity 
        WHERE employee_id = @employeeId AND product_id = @productId AND is_paid = FALSE";

            string insertQuery = @"
        INSERT INTO Cart (employee_id, product_id, quantity, is_paid) 
        VALUES (@employeeId, @productId, @quantity, FALSE)";

            using (var conn = DatabaseConnection.GetInstance())
            {
                conn.Open();

                using (var checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@employeeId", employeeId);
                    checkCmd.Parameters.AddWithValue("@productId", productId);

                    object result = checkCmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        using (var updateCmd = new MySqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@quantity", quantity);
                            updateCmd.Parameters.AddWithValue("@employeeId", employeeId);
                            updateCmd.Parameters.AddWithValue("@productId", productId);

                            return updateCmd.ExecuteNonQuery() > 0;
                        }
                    }
                    else
                    {
                        using (var insertCmd = new MySqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@employeeId", employeeId);
                            insertCmd.Parameters.AddWithValue("@productId", productId);
                            insertCmd.Parameters.AddWithValue("@quantity", quantity);

                            return insertCmd.ExecuteNonQuery() > 0;
                        }
                    }
                }
            }
        }



        public bool AddProduct(Product product)
        {
            using (var conn = DatabaseConnection.GetInstance())
            {
                conn.Open();

                string query = @"
            INSERT INTO Products (name, description, price, category_id, stock_level, image_path, is_available)
            VALUES (@name, @description, @price, @category_id, @stock_level, @image_path, @is_available)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", product.Name);
                    cmd.Parameters.AddWithValue("@description", string.IsNullOrEmpty(product.Description) ? DBNull.Value : product.Description);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@category_id", product.CategoryId.HasValue ? product.CategoryId : DBNull.Value);
                    cmd.Parameters.AddWithValue("@stock_level", product.StockLevel);
                    cmd.Parameters.AddWithValue("@image_path", string.IsNullOrEmpty(product.ImagePath) ? DBNull.Value : product.ImagePath);
                    cmd.Parameters.AddWithValue("@is_available", product.IsAvailable);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

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
