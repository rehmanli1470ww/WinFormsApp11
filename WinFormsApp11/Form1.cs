using System.Text.Json;
using System.Text.RegularExpressions;

namespace WinFormsApp11
{

    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();
        JsonSerializerOptions options = new JsonSerializerOptions();

        public string? genderr;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            string jsonperson = File.ReadAllText("../../../person.json");
            persons = JsonSerializer.Deserialize<List<Person>>(jsonperson);
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            int yoxla = 0;
            foreach (var item in persons)
            {
                if (nameTb.Text==item.Name&& SurnameTb.Text == item.Surname&& FnameTb.Text == item.Fname&&
                    CountryTb.Text == item.Country&& cityTb.Text == item.City&& PhoneTb.Text == item.Phone)
                {
                    yoxla++;


                }
            }
            if (yoxla == 0)
            {
                if (menRb.Checked == true)
                {
                    genderr = "Kisi";

                }
                else
                {
                    genderr = "Qadin";
                }
                Person person = new Person(nameTb.Text, SurnameTb.Text, FnameTb.Text, CountryTb.Text, cityTb.Text, PhoneTb.Text, dateTimePicker1.Value, genderr);
                persons.Add(person);
                options.WriteIndented = true;
                string jsonstr = JsonSerializer.Serialize(persons, options);
                File.WriteAllText("../../../person.json", jsonstr);
                nameTb.Text = " ";
                SurnameTb.Text = " ";
                FnameTb.Text = " ";
                CountryTb.Text = " ";
                cityTb.Text = " ";
                PhoneTb.Text = " ";
                dateTimePicker1.Value = DateTime.Now;
                menRb.Checked = false;
                womenRb.Checked = false;


            }
            else
            {
                MessageBox.Show("Artiq hemin adda istifadeci movcuddur");
            }



        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var item in persons)
            {
                if (item.Name == SerchTb.Text)
                {
                    i++;
                    nameTb.Text = item.Name;
                    SurnameTb.Text = item.Surname;
                    FnameTb.Text = item.Fname;
                    CountryTb.Text = item.Country;
                    cityTb.Text = item.City;
                    PhoneTb.Text = item.Phone;
                    dateTimePicker1.Value = item.Date;
                    if (item.Gender == "Kisi")
                    {
                        menRb.Checked = true;
                        womenRb.Checked = false;
                    }
                    else
                    {
                        womenRb.Checked = true;
                        menRb.Checked = false;
                    }

                }
            }
            if (i == 0)
            {
                MessageBox.Show("Ele adda insan yoxdur");
            }

        }

        private void nameTb_TextChanged(object sender, EventArgs e)
        {
            string paternName = @"^([A-Z]{1})([a-z])+$";
            if (Regex.IsMatch(nameTb.Text, paternName))
            {
                nameTb.ForeColor = Color.Green;
            }
            else
            {
                nameTb.ForeColor = Color.Red;
            }
        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {
            string paternName = @"^(050|051|077|070|055|099|010)\s(\d{3})\s(\d{2})\s(\d{2})$";
            if (Regex.IsMatch(PhoneTb.Text, paternName))
            {
                PhoneTb.ForeColor = Color.Green;
            }
            else
            {
                PhoneTb.ForeColor = Color.Red;
            }

        }

        private void SurnameTb_TextChanged(object sender, EventArgs e)
        {
            string paternName = @"^([A-Z]{1})([a-z])+$";
            if (Regex.IsMatch(SurnameTb.Text, paternName))
            {
                SurnameTb.ForeColor = Color.Green;
            }
            else
            {
                SurnameTb.ForeColor = Color.Red;
            }

        }

        private void FnameTb_TextChanged(object sender, EventArgs e)
        {
            string paternName = @"^([A-Z]{1})([a-z])+$";
            if (Regex.IsMatch(FnameTb.Text, paternName))
            {
                FnameTb.ForeColor = Color.Green;
            }
            else
            {
                FnameTb.ForeColor = Color.Red;
            }

        }

        private void CountryTb_TextChanged(object sender, EventArgs e)
        {
            string paternName = @"^([A-Z]{1})([a-z])+$";
            if (Regex.IsMatch(CountryTb.Text, paternName))
            {
                CountryTb.ForeColor = Color.Green;
            }
            else
            {
                CountryTb.ForeColor = Color.Red;
            }

        }

        private void cityTb_TextChanged(object sender, EventArgs e)
        {
            string paternName = @"^([A-Z]{1})([a-z])+$";
            if (Regex.IsMatch(cityTb.Text, paternName))
            {
                cityTb.ForeColor = Color.Green;
            }
            else
            {
                cityTb.ForeColor = Color.Red;
            }

        }

        private void SerchTb_TextChanged(object sender, EventArgs e)
        {
            string paternName = @"^([A-Z]{1})([a-z])+$";
            if (Regex.IsMatch(SerchTb.Text, paternName))
            {
                SerchTb.ForeColor = Color.Green;
            }
            else
            {
                SerchTb.ForeColor = Color.Red;
            }
        }
    }
}