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
            string productsText = "�r�nler";
            var addToCartButtonText = "Sepete ekle";
            var cartText = "Sepetiniz";
            string removeToCartButtonText = "Sepetten kald�r";

            lblProducts.Text = productsText;
            btnAddToCart.Text = addToCartButtonText;
            lblCart.Text = cartText;
            btnRemoveToCart.Text = removeToCartButtonText;
    
            string[] products = new string[] { "Laptop", "Masa�st� PC", "Klavye" };

            /*   for(int i = 0; i < products.Length; i++)
               {
                   lbxProducts.Items.Add(products[i]);
               }*/
            
            foreach (string product in products)
            {
                lbxProducts.Items.Add(product);
            }

            // �r�nlerden se�im yap�p butona t�klad���m�zda yan listbox a ge�mesini istiyoruz.

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveToCart.Enabled = false; // sepette �r�n yoksa t�klanabirlik gider.
            }
            if (lbxProducts.Items.Count == 0)
            {
                btnAddToCart.Enabled = false;
            }

        }
        // �r�nlerden se�im yap�p butona t�klad���m�zda yan listbox a ge�mesini istiyoruz.
        // alttaki sekme ��kmas� i�in form design a gittik ve �ift t�klad�k.
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
             if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                MessageBox.Show(lbxProducts.SelectedItem + " Sepete Eklendi.");
                lbxProducts.Items.Remove(lbxProducts.SelectedItem); // �r�n ekledi�im zaman soldaki sekmeden siliyor.
                btnRemoveToCart.Enabled = true; // �r�n ekledi�inde enable ederiz.
                btnAddToCart.Enabled = true;
            }
            else
            {
                MessageBox.Show("�nce bir eleman secmelisiniz.");
            }

            
        }

        private void btnRemoveToCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
                // lbxProducts.Items.Add(lbxCart.SelectedItem);
                MessageBox.Show(lbxCart.SelectedItem+ " Sepetten Kald�r�ld�.");
                

            }
            else
            {
                MessageBox.Show("�nce bir eleman secmelisiniz.");
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveToCart.Enabled = false; // sepette �r�n yoksa t�klanabirlik gider.
            }

        }
    }
}