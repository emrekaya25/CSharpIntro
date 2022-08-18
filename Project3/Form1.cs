namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> students; // heryerde kullanmak i�in en �stte tan�mlad�k.
        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string>() { "Emre Kaya","G�zde Kaya","Kamil Kaya"};
            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (tbxStudentName.Text.Length <= 2)
            {
                MessageBox.Show("��renci ismi en az 2 karakter olmal�d�r.");
            }
            else
            {
                students.Add(tbxStudentName.Text);
                // lbxStudentList.Items.Add(tbxStudentName.Text); // bu kodda tek ba��na ekleme yap�yor
                lbxStudentList.Items.Clear(); // burda silmemizin sebebi altta b�t�n listeyi tekrardan eklememiz.

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
                MessageBox.Show("Bir ��renci Se�iniz..");
            }
            else
            {
                students.Remove((string)lbxStudentList.SelectedItem); //selected item object dedi�imiz yap�yla geliyor bu y�zden stringe �evirdik
                lbxStudentList.Items.Clear();
                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            }

        }
    }
}