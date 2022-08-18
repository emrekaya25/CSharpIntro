namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string productsText = "Ürünler";
            var addToCartButtonText = "Sepete ekle";
            var cartText = "Sepetiniz";
            string removeToCartButtonText = "Sepetten kaldýr";

            lblProducts.Text = productsText;
            btnAddToCart.Text = addToCartButtonText;
            lblCart.Text = cartText;
            btnRemoveToCart.Text = removeToCartButtonText;
    
            string[] products = new string[] { "Laptop", "Masaüstü PC", "Klavye" };

            /*   for(int i = 0; i < products.Length; i++)
               {
                   lbxProducts.Items.Add(products[i]);
               }*/
            
            foreach (string product in products)
            {
                lbxProducts.Items.Add(product);
            }

            // ürünlerden seçim yapýp butona týkladýðýmýzda yan listbox a geçmesini istiyoruz.

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveToCart.Enabled = false; // sepette ürün yoksa týklanabirlik gider.
            }
            if (lbxProducts.Items.Count == 0)
            {
                btnAddToCart.Enabled = false;
            }

        }
        // ürünlerden seçim yapýp butona týkladýðýmýzda yan listbox a geçmesini istiyoruz.
        // alttaki sekme çýkmasý için form design a gittik ve çift týkladýk.
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
             if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                MessageBox.Show(lbxProducts.SelectedItem + " Sepete Eklendi.");
                lbxProducts.Items.Remove(lbxProducts.SelectedItem); // ürün eklediðim zaman soldaki sekmeden siliyor.
                btnRemoveToCart.Enabled = true; // ürün eklediðinde enable ederiz.
                btnAddToCart.Enabled = true;
            }
            else
            {
                MessageBox.Show("Önce bir eleman secmelisiniz.");
            }

            
        }

        private void btnRemoveToCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
                // lbxProducts.Items.Add(lbxCart.SelectedItem);
                MessageBox.Show(lbxCart.SelectedItem+ " Sepetten Kaldýrýldý.");
                

            }
            else
            {
                MessageBox.Show("Önce bir eleman secmelisiniz.");
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveToCart.Enabled = false; // sepette ürün yoksa týklanabirlik gider.
            }

        }
    }
}