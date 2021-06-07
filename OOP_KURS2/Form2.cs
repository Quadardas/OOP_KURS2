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
    public partial class Form2 : Form
    {
        public Form2(Form1 getform)
        {
            form1 = getform;
            InitializeComponent();
            #region
            ZubCheckBoxes.Add(_11CB);
            ZubCheckBoxes.Add(_12CB);
            ZubCheckBoxes.Add(_13CB);
            ZubCheckBoxes.Add(_14CB);
            ZubCheckBoxes.Add(_15CB);
            ZubCheckBoxes.Add(_16CB);
            ZubCheckBoxes.Add(_17CB);
            ZubCheckBoxes.Add(_18CB);
            ZubCheckBoxes.Add(_21CB);
            ZubCheckBoxes.Add(_22CB);
            ZubCheckBoxes.Add(_23CB);
            ZubCheckBoxes.Add(_24CB);
            ZubCheckBoxes.Add(_25CB);
            ZubCheckBoxes.Add(_26CB);
            ZubCheckBoxes.Add(_27CB);
            ZubCheckBoxes.Add(_28CB);
            ZubCheckBoxes.Add(_31CB);
            ZubCheckBoxes.Add(_32CB);
            ZubCheckBoxes.Add(_33CB);
            ZubCheckBoxes.Add(_34CB);
            ZubCheckBoxes.Add(_45CB);
            ZubCheckBoxes.Add(_36CB);
            ZubCheckBoxes.Add(_37CB);
            ZubCheckBoxes.Add(_38CB);
            ZubCheckBoxes.Add(_41CB);
            ZubCheckBoxes.Add(_42CB);
            ZubCheckBoxes.Add(_43CB);
            ZubCheckBoxes.Add(_44CB);
            ZubCheckBoxes.Add(_45CB);
            ZubCheckBoxes.Add(_46CB);
            ZubCheckBoxes.Add(_47CB);
            ZubCheckBoxes.Add(_48CB);
            #endregion
        }
        public List<CheckBox> ZubCheckBoxes = new List<CheckBox>();
        public List<string> BadZubs = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox c in ZubCheckBoxes)
            {
                if (c.Checked)
                {
                    BadZubs.Add(c.Text);
                    c.Checked = false;
                }
            }
            foreach(string b in BadZubs)
            {
                form1.listBox1.Items.Add(b);
            }
            
        }
            public Form1 form1;
      
    }
    
}

