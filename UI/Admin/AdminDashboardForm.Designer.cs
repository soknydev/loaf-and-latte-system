namespace loaf_and_latte_system.UI.Admin
{
    partial class AdminDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSidebar12 = new loaf_and_latte_system.Components.Buttons.ButtonSidebar1();
            this.buttonSidebar11 = new loaf_and_latte_system.Components.Buttons.ButtonSidebar1();
            this.buttonSidebar1 = new loaf_and_latte_system.Components.Buttons.ButtonSidebar();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1791, 752);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(214, 746);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSidebar12);
            this.panel1.Controls.Add(this.buttonSidebar11);
            this.panel1.Controls.Add(this.buttonSidebar1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 640);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::loaf_and_latte_system.Properties.Resources.bms;
            this.pictureBox1.Location = new System.Drawing.Point(23, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(223, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1565, 746);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.flowLayoutPanelProducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1559, 670);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanelProducts
            // 
            this.flowLayoutPanelProducts.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelProducts.Location = new System.Drawing.Point(16, 18);
            this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            this.flowLayoutPanelProducts.Size = new System.Drawing.Size(1354, 282);
            this.flowLayoutPanelProducts.TabIndex = 0;
            this.flowLayoutPanelProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelProducts_Paint);
            // 
            // buttonSidebar12
            // 
            this.buttonSidebar12.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSidebar12.BackgroundColor = System.Drawing.SystemColors.Control;
            this.buttonSidebar12.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSidebar12.BorderRadius = 10;
            this.buttonSidebar12.BorderSize = 0;
            this.buttonSidebar12.FlatAppearance.BorderSize = 0;
            this.buttonSidebar12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSidebar12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.buttonSidebar12.ForeColor = System.Drawing.Color.Black;
            this.buttonSidebar12.Location = new System.Drawing.Point(23, 291);
            this.buttonSidebar12.Name = "buttonSidebar12";
            this.buttonSidebar12.Padding = new System.Windows.Forms.Padding(15, 5, 30, 5);
            this.buttonSidebar12.Size = new System.Drawing.Size(160, 50);
            this.buttonSidebar12.TabIndex = 4;
            this.buttonSidebar12.Text = "Categories";
            this.buttonSidebar12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSidebar12.TextColor = System.Drawing.Color.Black;
            this.buttonSidebar12.UseVisualStyleBackColor = false;
            // 
            // buttonSidebar11
            // 
            this.buttonSidebar11.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSidebar11.BackgroundColor = System.Drawing.SystemColors.Control;
            this.buttonSidebar11.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSidebar11.BorderRadius = 10;
            this.buttonSidebar11.BorderSize = 0;
            this.buttonSidebar11.FlatAppearance.BorderSize = 0;
            this.buttonSidebar11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSidebar11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.buttonSidebar11.ForeColor = System.Drawing.Color.Black;
            this.buttonSidebar11.Location = new System.Drawing.Point(23, 221);
            this.buttonSidebar11.Name = "buttonSidebar11";
            this.buttonSidebar11.Padding = new System.Windows.Forms.Padding(15, 5, 30, 5);
            this.buttonSidebar11.Size = new System.Drawing.Size(160, 50);
            this.buttonSidebar11.TabIndex = 3;
            this.buttonSidebar11.Text = "Categories";
            this.buttonSidebar11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSidebar11.TextColor = System.Drawing.Color.Black;
            this.buttonSidebar11.UseVisualStyleBackColor = false;
            // 
            // buttonSidebar1
            // 
            this.buttonSidebar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.buttonSidebar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.buttonSidebar1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSidebar1.BorderRadius = 10;
            this.buttonSidebar1.BorderSize = 0;
            this.buttonSidebar1.FlatAppearance.BorderSize = 0;
            this.buttonSidebar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSidebar1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.buttonSidebar1.ForeColor = System.Drawing.Color.White;
            this.buttonSidebar1.Location = new System.Drawing.Point(23, 148);
            this.buttonSidebar1.Name = "buttonSidebar1";
            this.buttonSidebar1.Padding = new System.Windows.Forms.Padding(15, 5, 30, 5);
            this.buttonSidebar1.Size = new System.Drawing.Size(160, 50);
            this.buttonSidebar1.TabIndex = 2;
            this.buttonSidebar1.Text = "Products";
            this.buttonSidebar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSidebar1.TextColor = System.Drawing.Color.White;
            this.buttonSidebar1.UseVisualStyleBackColor = false;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 752);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private Components.Buttons.ButtonSidebar1 buttonSidebar12;
        private Components.Buttons.ButtonSidebar1 buttonSidebar11;
        private Components.Buttons.ButtonSidebar buttonSidebar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
    }
}