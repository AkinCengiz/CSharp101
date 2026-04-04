namespace ClassesForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private Student[] students = new Student[5];
    private int id = 1;
    private List<Student> studentList = new List<Student>();
    private void Form1_Load(object sender, EventArgs e)
    {
        lblSehir.Text = "Şehir Adı :";
        lblSehirListesi.Text = "Şehir Listesi";
        lblSehirListesi.ForeColor = Color.DarkBlue;
        //students = new Student[5];
        //Ders[] dersler = new Ders[5];
    }

    private void btnChange_Click(object sender, EventArgs e)
    {

    }

    private void gbxStudent_Enter(object sender, EventArgs e)
    {

    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        Student student = new Student();
        student.FirstName = txtFirstName.Text;
        student.LastName = txtLastName.Text;
        student.Number = txtNumber.Text;
        student.Id = id;
        id++;
        students[student.Id - 1] = student;
        studentList.Add(student);


        lbxSehirler.Items.Clear();
        ListDoldur();

    }

    void ListDoldur()
    {
        foreach (var item in students)
        {
            lbxSehirler.Items.Add(item.FirstName + " " + item.LastName);
        }
    }

    //ÖĞRENCİ TOSTRİNG
}
