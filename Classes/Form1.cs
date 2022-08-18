namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.FirstName = "Emre Kaya";
            student1.Age = 20;
            student1.Mail = "emrekaya@gmail.com";

            Student student2 = new Student();
            student2.FirstName = "Hayri Zengin";
            student2.Age = 19;
            student2.Mail = "hayrizengin@gmail.com";

            List<Student> students = new List<Student>() { student1,student2};

            foreach (var student in students)
            {
                // lbxStudents.Items.Add(student); // bu şekilde eklemede hata verir Classes.student adında yazdırır.
                lbxStudents.Items.Add(student.FirstName + " | " + student.Mail);
            }

            dgrwStudents.DataSource = students;
            
        }
    }
}