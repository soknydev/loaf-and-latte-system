using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using loaf_and_latte_system.Models;

namespace loaf_and_latte_system.UI.Controls
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        public void SetProductData(Product product)
        {
            lblName.Text = $"{product.Name}";
            lblDescription.Text = $"{product.Description}";
            lblPrice.Text = $"{product.Price}";
            lblStock.Text = $"{product.StockLevel}";
            lblAvailable.Text = $"{(product.IsAvailable ? "Yes" : "No")}";

            // Load image if path exists
            if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
            {
                pictureBox.Image = Image.FromFile(product.ImagePath);
            }
        }
    }
}
