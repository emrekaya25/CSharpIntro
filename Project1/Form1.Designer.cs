namespace Project1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxProducts = new System.Windows.Forms.ListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lbxCart = new System.Windows.Forms.ListBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnRemoveToCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxProducts
            // 
            this.lbxProducts.FormattingEnabled = true;
            this.lbxProducts.ItemHeight = 20;
            this.lbxProducts.Location = new System.Drawing.Point(12, 70);
            this.lbxProducts.Name = "lbxProducts";
            this.lbxProducts.Size = new System.Drawing.Size(171, 304);
            this.lbxProducts.TabIndex = 0;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(51, 9);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(0, 20);
            this.lblProducts.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(189, 70);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(139, 29);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "button1";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lbxCart
            // 
            this.lbxCart.FormattingEnabled = true;
            this.lbxCart.ItemHeight = 20;
            this.lbxCart.Location = new System.Drawing.Point(376, 75);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(157, 124);
            this.lbxCart.TabIndex = 3;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(376, 44);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(50, 20);
            this.lblCart.TabIndex = 4;
            this.lblCart.Text = "label1";
            // 
            // btnRemoveToCart
            // 
            this.btnRemoveToCart.Location = new System.Drawing.Point(583, 78);
            this.btnRemoveToCart.Name = "btnRemoveToCart";
            this.btnRemoveToCart.Size = new System.Drawing.Size(155, 29);
            this.btnRemoveToCart.TabIndex = 5;
            this.btnRemoveToCart.Text = "button1";
            this.btnRemoveToCart.UseVisualStyleBackColor = true;
            this.btnRemoveToCart.Click += new System.EventHandler(this.btnRemoveToCart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveToCart);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lbxCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lbxProducts);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbxProducts;
        private Label lblProducts;
        private Button btnAddToCart;
        private ListBox lbxCart;
        private Label lblCart;
        private Button btnRemoveToCart;
    }
}