namespace Project2
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
            this.lblCars = new System.Windows.Forms.Label();
            this.lbxCarNames = new System.Windows.Forms.ListBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Location = new System.Drawing.Point(12, 40);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(50, 20);
            this.lblCars.TabIndex = 0;
            this.lblCars.Text = "label1";
            this.lblCars.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbxCarNames
            // 
            this.lbxCarNames.FormattingEnabled = true;
            this.lbxCarNames.ItemHeight = 20;
            this.lbxCarNames.Location = new System.Drawing.Point(12, 80);
            this.lbxCarNames.Name = "lbxCarNames";
            this.lbxCarNames.Size = new System.Drawing.Size(145, 244);
            this.lbxCarNames.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(171, 81);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(115, 29);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "button1";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lbxCarNames);
            this.Controls.Add(this.lblCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCars;
        private ListBox lbxCarNames;
        private Button btnAddToCart;
    }
}