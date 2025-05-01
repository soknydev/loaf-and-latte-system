using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using loaf_and_latte_system.Models;
using loaf_and_latte_system.Repositories;
using loaf_and_latte_system.Util;

namespace loaf_and_latte_system.UI.Controls
{
    public partial class ProductCard : UserControl
    {
        private readonly ProductRepository _productRepository;
        private Product _product;

        public ProductCard()
        {
            InitializeComponent();
            _productRepository = new ProductRepository(); // Ensure it's initialized
        }

        public void SetProductData(Product product)
        {
            _product = product;

            lblName.Text = product.Name;
            lblPrice.Text = product.Price.ToString("C"); // Currency format

            if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
            {
                pictureBox.Image = Image.FromFile(product.ImagePath);
            }
            else
            {
                pictureBox.Image = null; // or set a default image
            }
        }



        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(UserSession.CurrentUser);

            if (_product == null)
            {
                MessageBox.Show("Product not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UserSession.CurrentUser == null || UserSession.CurrentUser.EmployeeId <= 0)
            {
                MessageBox.Show("User session is invalid. Please log in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int employeeId = UserSession.CurrentUser.EmployeeId;
           MessageBox.Show($"Employee ID: {employeeId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                bool isAdded = _productRepository.AddToCart(employeeId, _product.ProductId, 1);
                if (isAdded)
                {
                    MessageBox.Show("Product added to cart successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add product to cart. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
