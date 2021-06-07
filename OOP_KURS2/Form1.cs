using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KURS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ServicesCB.Text = " ";
        }
        private void ServicesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ServicesCB.Text)
            {
                case "Лечение десен": TypeCB.Items.Clear(); TypeCB.Enabled = false;  break;
                case "Лечение Кариеса": TypeCB.Items.Clear(); TypeCB.Enabled = false; break;
                case "Резекция верхушки корня": TypeCB.Items.Clear(); TypeCB.Enabled = false; break;
                case "Удаление зуба": TypeCB.Items.Clear(); TypeCB.Enabled = false;  break;
                case "Отбеливание зубов":
                    TypeCB.Items.Clear();
                    TypeCB.Enabled = true;
                    TypeCB.Items.Add("Механический метод");
                    TypeCB.Items.Add("Фотоотбеливание");
                    TypeCB.Items.Add("Химическое отбеливание");
                    TypeCB.Items.Add("Внутриканальное отбеливание");
                    TypeCB.Items.Add("Лазерное отбеливание");
                     break;
                case "Удаление зубного камня":
                    TypeCB.Enabled = true;
                    TypeCB.Items.Clear();
                    TypeCB.Items.Add("Механическая чистка");
                    TypeCB.Items.Add("Пескоструйная обработка");
                    TypeCB.Items.Add("Ультразвуком");
                    TypeCB.Items.Add("Лазером"); break;
            }
        }
        private void AddPat()
        {
            Patient patient = new Patient(ServicesCB.Text, PatPassTB.Text, NamePatTB.Text, numericUpDown1.Value.ToString());
            DB.patients.Add(patient);
            switch (ServicesCB.Text)
            {
                case "Лечение десен": patient.setThisService = new Lech_Des("Лечение десен", 3000, "Лечение десен"); break;
                case "Лечение кариеса": patient.setThisService = new Lech_Kar("Лечение кариеса", 3000, "Лечение кариеса"); break;
                case "Резекция верхушки корня": patient.setThisService = new Rezec("Резекция верхушки корня", 1500, "Резекция"); break;
                case "Удаление зуба": patient.setThisService = new UdalZuba("Удаление зуба", 800, "Удаление зуба"); break;
                case "Отбеливание зубов": patient.setThisService = new Otbel(TypeCB.Text, "Отбеливание зубов", "Отбеливание зубов", 9000); break;
                case "Удаление зубного камня": patient.setThisService = new ZubCumIn(TypeCB.Text, "Удаление зубного камня", "Удаление зубного камня", 200); break;
            }
        }
        private void AddPatBTN_Click(object sender, EventArgs e)
        {
            AddPat();
        }
        public void AddDoc()
        {
            Doctor doctor = new Doctor(StazhDoc.Value.ToString(), EducCB.Text, NameDocTB.Text, AgeDoc.Value.ToString());
            DB.doctors.Add(doctor);
            switch (EducCB.Text)
            {
                case "стоматолог-терапевт": doctor.setThisService = new Lech_Des("Лечение десен", 3000, "Лечение десен"); doctor.setThisService = new Lech_Kar("Лечение кариеса", 3000, "Лечение кариеса"); break;
                case "Стоматолог-хирург": doctor.setThisService = new Rezec("Резекция верхушки корня", 1500, "Резекция"); doctor.setThisService = new UdalZuba("Удаление зуба", 800, "Удаление зуба"); break;
                case "стоматолог-гигиенист": doctor.setThisService = new Otbel("Механический метод, Фотоотбеливание, Химическое отбеливание, Внутриканальное отбеливание, Лазерное отбеливание", "Отбеливание зубов", "Отбеливание зубов", 9000); doctor.setThisService = new ZubCumIn("Механическая чистка, Пескоструйная обработка, Ультразвуком, Лазером", "Удаление зубного камня", "Удаление зубного камня", 200); break;
            }
            UpdateGrid();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddDoc();
        }
        string educ;
       
        void UpdateGrid()
        {
            DataGridDoc.Rows.Clear();
            foreach(Doctor doc in DB.doctors)
            {
                educ = String.Empty;

                foreach(Services s in doc.thisService)
                {
                    educ += s.thisServicesName + ", ";
                }
                /*switch (EducCB.SelectedItem)
                {
                    case "стоматолог-терапевт": 
                }*/
                DataGridDoc.Rows.Add(doc.thisName, doc.thisEducation, doc.thisAge, doc.thisStazh, educ);

            }
        }

        private void AgeDoc_Scroll(object sender, EventArgs e)
        {
            label2.Text = AgeDoc.Value.ToString();
        }

        private void StazhDoc_Scroll(object sender, EventArgs e)
        {
            label3.Text = StazhDoc.Value.ToString();
        }
        private void OpenForm2()
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
               if (ServicesCB.Text == "Лечение Кариеса" || ServicesCB.Text == "Резекция верхушки корня" || ServicesCB.Text == "Удаление зуба")
                {
                    OpenForm2();
                }
            }
            catch (Exception)
            {

            }

        }
    }
}
