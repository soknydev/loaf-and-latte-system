using loaf_and_latte_system.Models;
using loaf_and_latte_system.Repositories;
using loaf_and_latte_system.UI.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace loaf_and_latte_system.UI.Admin
{
    public partial class AdminDashboardForm: Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadProducts();
        }


        private void LoadProducts()
        {
            List<Product> products = ProductRepository.GetAllProducts();

            foreach (var product in products)
            {
                ProductCard card = new ProductCard();
                card.SetProductData(product);
                flowLayoutPanelProducts.Controls.Add(card);
            }
        }

        private void flowLayoutPanelProducts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
