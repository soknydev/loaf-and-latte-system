namespace loaf_and_latte_system.UI.Controls
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonComponent11 = new loaf_and_latte_system.Components.Buttons.ButtonComponent1();
            this.btnAddToCart = new loaf_and_latte_system.Components.Buttons.ButtonComponent1();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(79, 237);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(157, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1112111";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(110, 283);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(97, 25);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "label1333";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::loaf_and_latte_system.Properties.Resources.bms;
            this.pictureBox.Location = new System.Drawing.Point(12, 59);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(297, 175);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // buttonComponent11
            // 
            this.buttonComponent11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.buttonComponent11.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.buttonComponent11.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonComponent11.BorderRadius = 10;
            this.buttonComponent11.BorderSize = 0;
            this.buttonComponent11.FlatAppearance.BorderSize = 0;
            this.buttonComponent11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComponent11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.buttonComponent11.ForeColor = System.Drawing.Color.White;
            this.buttonComponent11.Location = new System.Drawing.Point(192, 324);
            this.buttonComponent11.Name = "buttonComponent11";
            this.buttonComponent11.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.buttonComponent11.Size = new System.Drawing.Size(116, 54);
            this.buttonComponent11.TabIndex = 11;
            this.buttonComponent11.Text = "Details";
            this.buttonComponent11.TextColor = System.Drawing.Color.White;
            this.buttonComponent11.UseVisualStyleBackColor = false;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.btnAddToCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.btnAddToCart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddToCart.BorderRadius = 10;
            this.btnAddToCart.BorderSize = 0;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(14, 324);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.btnAddToCart.Size = new System.Drawing.Size(167, 54);
            this.btnAddToCart.TabIndex = 10;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.TextColor = System.Drawing.Color.White;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Image = global::loaf_and_latte_system.Properties.Resources.edit;
            this.pictureBoxUpdate.Location = new System.Drawing.Point(211, 6);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(43, 39);
            this.pictureBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUpdate.TabIndex = 8;
            this.pictureBoxUpdate.TabStop = false;
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Image = global::loaf_and_latte_system.Properties.Resources.trash;
            this.pictureBoxDelete.Location = new System.Drawing.Point(265, 6);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(43, 39);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDelete.TabIndex = 9;
            this.pictureBoxDelete.TabStop = false;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.buttonComponent11);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.pictureBoxDelete);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(326, 408);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox pictureBox;
        private Components.Buttons.ButtonComponent1 btnAddToCart;
        private Components.Buttons.ButtonComponent1 buttonComponent11;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
    }
}
