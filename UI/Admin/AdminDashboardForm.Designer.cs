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
            this.buttonComponent11 = new bakery_management_system.components.ButtonComponent1();
            this.SuspendLayout();
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
            this.buttonComponent11.Location = new System.Drawing.Point(225, 142);
            this.buttonComponent11.Name = "buttonComponent11";
            this.buttonComponent11.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.buttonComponent11.Size = new System.Drawing.Size(263, 55);
            this.buttonComponent11.TabIndex = 0;
            this.buttonComponent11.Text = "buttonComponent11";
            this.buttonComponent11.TextColor = System.Drawing.Color.White;
            this.buttonComponent11.UseVisualStyleBackColor = false;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 770);
            this.Controls.Add(this.buttonComponent11);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private bakery_management_system.components.ButtonComponent1 buttonComponent11;
    }
}