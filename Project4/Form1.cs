namespace Project4
{
    public partial class Form1 : Form
    {
        private object customers;

        public Form1()
        {
            InitializeComponent();
        }
        CustomerManager customerManager = new CustomerManager(); // hata almamak için en üste taþýdýk.
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dgrwCustomers.DataSource = customerManager.GetCustomers(); //data grid view in verisi burdan geliyor demek.
            dgrwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // çýkan datadaki þablonu dolduruyor
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Id = Convert.ToInt32(tbxId.Text); // int e çeviriyoruz.
            customer.FirstName = tbxFirstName.Text;
            customer.LastName = tbxLastName.Text;
            customer.Email = tbxEmail.Text;
            customer.City = tbxCity.Text;


            
            customerManager.Add(customer);
            dgrwCustomers.DataSource = null;
            dgrwCustomers.DataSource = customerManager.GetCustomers();



        }
    }
}