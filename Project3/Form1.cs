namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> students; // heryerde kullanmak için en üstte tanýmladýk.
        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string>() { "Emre Kaya","Gözde Kaya","Kamil Kaya"};
            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (tbxStudentName.Text.Length <= 2)
            {
                MessageBox.Show("Öðrenci ismi en az 2 karakter olmalýdýr.");
            }
            else
            {
                students.Add(tbxStudentName.Text);
                // lbxStudentList.Items.Add(tbxStudentName.Text); // bu kodda tek baþýna ekleme yapýyor
                lbxStudentList.Items.Clear(); // burda silmemizin sebebi altta bütün listeyi tekrardan eklememiz.

                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            }
            
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lbxStudentList.SelectedItem == null)
            {
                MessageBox.Show("Bir Öðrenci Seçiniz..");
            }
            else
            {
                students.Remove((string)lbxStudentList.SelectedItem); //selected item object dediðimiz yapýyla geliyor bu yüzden stringe çevirdik
                lbxStudentList.Items.Clear();
                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            }

        }
    }
}