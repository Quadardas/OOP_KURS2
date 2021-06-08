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
            switch (ServicesCB.SelectedItem.ToString())
            {
                case "Лечение дёсен":
                    {
                        selectDocCB.Items.Clear();
                        TypeCB.Items.Clear(); TypeCB.Enabled = false;
                        foreach(Doctor d in DB.doctors)
                        {
                            foreach(Services s in d.thisService)
                            {
                                if (ServicesCB.SelectedItem.ToString() == s.thisServicesName) selectDocCB.Items.Add(d.thisName);
                            }
                        } 
                        break;
                    }
                   
                case "Лечение Кариеса":
                    {
                        selectDocCB.Items.Clear();
                        TypeCB.Items.Clear(); TypeCB.Enabled = false;
                        foreach (Doctor d in DB.doctors)
                        {
                            foreach (Services s in d.thisService)
                            {
                                if (ServicesCB.SelectedItem.ToString() == s.thisServicesName) selectDocCB.Items.Add(d.thisName);
                            }
                        }
                        break;
                    }
                case "Резекция верхушки корня":
                    {
                        selectDocCB.Items.Clear();
                        TypeCB.Items.Clear(); TypeCB.Enabled = false;
                        foreach (Doctor d in DB.doctors)
                        {
                            foreach (Services s in d.thisService)
                            {
                                if (ServicesCB.SelectedItem.ToString() == s.thisServicesName) selectDocCB.Items.Add(d.thisName);
                            }
                        }
                        break;
                    }
                case "Удаление зуба":
                    {
                        selectDocCB.Items.Clear();
                        TypeCB.Items.Clear(); TypeCB.Enabled = false;
                        foreach (Doctor d in DB.doctors)
                        {
                            foreach (Services s in d.thisService)
                            {
                                if (ServicesCB.SelectedItem.ToString() == s.thisServicesName) selectDocCB.Items.Add(d.thisName);
                            }
                        }
                        break;
                    }
                case "Отбеливание зубов":
                    {
                        TypeCB.Items.Clear();
                        TypeCB.Enabled = true;
                        TypeCB.Items.Add("Механический метод");
                        TypeCB.Items.Add("Фотоотбеливание");
                        TypeCB.Items.Add("Химическое отбеливание");
                        TypeCB.Items.Add("Внутриканальное отбеливание");
                        TypeCB.Items.Add("Лазерное отбеливание");
                        selectDocCB.Items.Clear();
                        // TypeCB.Items.Clear(); // TypeCB.Enabled = false;
                        foreach (Doctor d in DB.doctors)
                        {
                            foreach (Services s in d.thisService)
                            {
                                if (ServicesCB.SelectedItem.ToString() == s.thisServicesName) selectDocCB.Items.Add(d.thisName);
                            }
                        }
                        break;
                    }
                case "Удаление зубного камня":
                    {
                        TypeCB.Enabled = true;
                        TypeCB.Items.Clear();
                        TypeCB.Items.Add("Механическая чистка");
                        TypeCB.Items.Add("Пескоструйная обработка");
                        TypeCB.Items.Add("Ультразвуком");
                        TypeCB.Items.Add("Лазером"); 
                        selectDocCB.Items.Clear();
                        // TypeCB.Items.Clear(); TypeCB.Enabled = false;
                        foreach (Doctor d in DB.doctors)
                        {
                            foreach (Services s in d.thisService)
                            {
                                if (ServicesCB.SelectedItem.ToString() == s.thisServicesName) selectDocCB.Items.Add(d.thisName);
                            }
                        }break;
                    }
            }
        }

        void CheckData()
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Добавить Врача":
                    {
                        if (NameDocTB.Text == string.Empty || EducCB.Text == string.Empty)
                        {
                            errorProvider1.SetError(button1, "Вы ввели неверные данные, проверьте и попробуйте еще раз");
                        }
                        else { AddDoc(); errorProvider1.Clear(); }
                        break;
                    }
                case "Запись Пациента":
                    {
                        if(ServicesCB.Text == string.Empty  || selectDocCB.Text == string.Empty || NamePatTB.Text == string.Empty || PatPassTB.Text == string.Empty || numericUpDown1.Value == 0 || listBox1.Items.Count == 0)
                        {
                            errorProvider1.SetError(AddPatBTN, "Вы ввели неверные данные, проверьте и попробуйте еще раз");
                        }
                        else { AddPat(); errorProvider1.Clear(); }
                        break;
                    }
            }
            
        }
        void ClearCB()
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Запись Пациента":
                    {
                        ServicesCB.Text = String.Empty;
                        selectDocCB.Text = String.Empty;
                        NamePatTB.Text = String.Empty;
                        PatPassTB.Text = String.Empty;
                        numericUpDown1.Value = 0;
                        break;
                    }
                case "Добавить Врача":
                    {
                        NameDocTB.Text = String.Empty;
                        EducCB.Text = String.Empty;
                        AgeDoc.Value = 23;
                        StazhDoc.Value = 3;
                        break;
                    }
            }
        }
        
        private void AddPat()
        {
            string Temp = string.Empty;
            foreach(string i in listBox1.Items)
            {
                Temp += $"{i}, ";
            }
            Patient patient = new Patient(Temp, ServicesCB.Text, PatPassTB.Text, NamePatTB.Text, numericUpDown1.Value.ToString(), TypeCB.Text, selectDocCB.Text);
            DB.patients.Add(patient);
            switch (ServicesCB.Text)
            {
                case "Лечение десен": patient.setThisService = new Lech_Des("Лечение дёсен", 3000, "Лечение дёсен"); break;
                case "Лечение Кариеса": patient.setThisService = new Lech_Kar("Лечение Кариеса", 3000, "Лечение Кариеса"); break;
                case "Резекция верхушки корня": patient.setThisService = new Rezec("Резекция верхушки корня", 1500, "Резекция"); break;
                case "Удаление зуба": patient.setThisService = new UdalZuba("Удаление зуба", 800, "Удаление зуба"); break;
                case "Отбеливание зубов": patient.setThisService = new Otbel(TypeCB.Text, "Отбеливание зубов", "Отбеливание зубов", 9000); break;
                case "Удаление зубного камня": patient.setThisService = new ZubCumIn(TypeCB.Text, "Удаление зубного камня", "Удаление зубного камня", 200); break;
            }
        }
        private void AddPatBTN_Click(object sender, EventArgs e)
        {
            CheckData();
            UpdateGrid();
            listBox1.Items.Clear();
            ClearCB();
        }
        public void AddDoc()
        {
            Doctor doctor = new Doctor(StazhDoc.Value.ToString(), EducCB.Text, NameDocTB.Text, AgeDoc.Value.ToString());
            DB.doctors.Add(doctor);
            switch (EducCB.Text)
            {
                case "стоматолог-терапевт": doctor.setThisService = new Lech_Des("Лечение дёсен", 3000, "Лечение дёсен"); doctor.setThisService = new Lech_Kar("Лечение Кариеса", 3000, "Лечение Кариеса"); break;
                case "Стоматолог-хирург": doctor.setThisService = new Rezec("Резекция верхушки корня", 1500, "Резекция"); doctor.setThisService = new UdalZuba("Удаление зуба", 800, "Удаление зуба"); break;
                case "стоматолог-гигиенист": doctor.setThisService = new Otbel("Механический метод, Фотоотбеливание, Химическое отбеливание, Внутриканальное отбеливание, Лазерное отбеливание", "Отбеливание зубов", "Отбеливание зубов", 9000); doctor.setThisService = new ZubCumIn("Механическая чистка, Пескоструйная обработка, Ультразвуком, Лазером", "Удаление зубного камня", "Удаление зубного камня", 200); break;
            }
            UpdateGrid();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckData();
            ClearCB();
           // AddDoc();
        }
        string educ;
        string jija;
        void UpdateGrid()
        {
            DataGridDoc.Rows.Clear();
            dataGridView1.Rows.Clear();
            jija = String.Empty;
            foreach (Doctor doc in DB.doctors)
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
            foreach(Patient pat in DB.patients)
            {
                dataGridView1.Rows.Add(pat.thisName, pat.thisService[0].thisServicesName, pat.thisType, pat.thisToHeal, pat.thisDoc, pat.thisService[0].thisPrice);
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

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            Serialize serialize = new Serialize();
            serialize.Save();
        }

        private void LoadBTN_Click(object sender, EventArgs e)
        {
            Serialize serialize = new Serialize();
            serialize.Load();
            UpdateGrid();
        }
    }
}
