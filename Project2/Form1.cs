namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] cars = new string[] 
            {"Toyota Verso","Ford Mustang","Toyota C-HR","Renault Megane","Honda Civic" };

            var lblcarstext = "Arabalar";
            var addToCartButton = "Kirala";
            
            lblCars.Text = lblcarstext;
            btnAddToCart.Text = addToCartButton;


            foreach (var car in cars)
            {
                lbxCarNames.Items.Add(car);
            }


            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}