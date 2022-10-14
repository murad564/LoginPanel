using System.Xml.Serialization;

namespace LoginPanel
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void Enter_Click(object sender, EventArgs e)
        {
            User user = new();

            user.name = Name.Text;
            user.surname = Surname.Text;
            user.age = Int32.Parse(Age.Text);
            user.fatherName = FatherName.Text;
            user.motherName = MotherName.Text;
            user.county = Country.Text;
            if (Male.Checked)
                user.gender = "Male";
            else
                user.gender = "FeMale";

            int i = 1;
            var xml = new XmlSerializer(typeof(User));
            using FileStream fs = new FileStream("User" + i.ToString() + ".xml", FileMode.OpenOrCreate, FileAccess.Write);
            xml.Serialize(fs, user);
            MessageBox.Show("Serializing is quite successfull!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new();

            var xml = new XmlSerializer(typeof(User));
            using var fs = new FileStream("User1.xml", FileMode.Open);
            user = xml.Deserialize(fs) as User;
            MessageBox.Show("Deserializing is quite successfull!");

            Name.Text = user.name;
            Surname.Text = user.surname;
            Age.Text = user.age.ToString();
            MotherName.Text = user.motherName;
            Country.Text = user.county;
            FatherName.Text = user.fatherName;

            if (user.gender == "Male")
                Male.Checked = true;
            else
                Female.Checked = true;


        }
    }
}