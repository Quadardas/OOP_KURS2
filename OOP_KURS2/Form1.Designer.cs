
namespace OOP_KURS2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.selectDocCB = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.PatPassTB = new System.Windows.Forms.TextBox();
            this.AddPatBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NamePatTB = new System.Windows.Forms.TextBox();
            this.ServicesCB = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridDoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.StazhDoc = new System.Windows.Forms.TrackBar();
            this.AgeDoc = new System.Windows.Forms.TrackBar();
            this.EducCB = new System.Windows.Forms.ComboBox();
            this.NameDocTB = new System.Windows.Forms.TextBox();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StazhDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 399);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.selectDocCB);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.TypeCB);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.PatPassTB);
            this.tabPage1.Controls.Add(this.AddPatBTN);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.NamePatTB);
            this.tabPage1.Controls.Add(this.ServicesCB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // selectDocCB
            // 
            this.selectDocCB.FormattingEnabled = true;
            this.selectDocCB.Location = new System.Drawing.Point(266, 6);
            this.selectDocCB.Name = "selectDocCB";
            this.selectDocCB.Size = new System.Drawing.Size(121, 21);
            this.selectDocCB.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(667, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(83, 56);
            this.listBox1.TabIndex = 7;
            // 
            // TypeCB
            // 
            this.TypeCB.Enabled = false;
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Location = new System.Drawing.Point(133, 6);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(121, 21);
            this.TypeCB.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(266, 33);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // PatPassTB
            // 
            this.PatPassTB.Location = new System.Drawing.Point(133, 33);
            this.PatPassTB.Name = "PatPassTB";
            this.PatPassTB.Size = new System.Drawing.Size(118, 20);
            this.PatPassTB.TabIndex = 4;
            // 
            // AddPatBTN
            // 
            this.AddPatBTN.Location = new System.Drawing.Point(6, 87);
            this.AddPatBTN.Name = "AddPatBTN";
            this.AddPatBTN.Size = new System.Drawing.Size(75, 23);
            this.AddPatBTN.TabIndex = 3;
            this.AddPatBTN.Text = "button1";
            this.AddPatBTN.UseVisualStyleBackColor = true;
            this.AddPatBTN.Click += new System.EventHandler(this.AddPatBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NamePatTB
            // 
            this.NamePatTB.Location = new System.Drawing.Point(6, 33);
            this.NamePatTB.Name = "NamePatTB";
            this.NamePatTB.Size = new System.Drawing.Size(121, 20);
            this.NamePatTB.TabIndex = 1;
            // 
            // ServicesCB
            // 
            this.ServicesCB.FormattingEnabled = true;
            this.ServicesCB.Items.AddRange(new object[] {
            "Лечение Кариеса",
            "Лечение дёсен",
            "Удаление зуба",
            "Резекция верхушки корня",
            "Отбеливание зубов",
            "Удаление зубного камня"});
            this.ServicesCB.Location = new System.Drawing.Point(6, 6);
            this.ServicesCB.Name = "ServicesCB";
            this.ServicesCB.Size = new System.Drawing.Size(121, 21);
            this.ServicesCB.TabIndex = 0;
            this.ServicesCB.Text = " ";
            this.ServicesCB.SelectedIndexChanged += new System.EventHandler(this.ServicesCB_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column10,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Имя пациента";
            this.Column6.Name = "Column6";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Вид услуги";
            this.Column10.Name = "Column10";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Тип услуги";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Что лечить";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Врач";
            this.Column9.Name = "Column9";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.DataGridDoc);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.StazhDoc);
            this.tabPage3.Controls.Add(this.AgeDoc);
            this.tabPage3.Controls.Add(this.EducCB);
            this.tabPage3.Controls.Add(this.NameDocTB);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // DataGridDoc
            // 
            this.DataGridDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DataGridDoc.Location = new System.Drawing.Point(6, 118);
            this.DataGridDoc.Name = "DataGridDoc";
            this.DataGridDoc.Size = new System.Drawing.Size(744, 249);
            this.DataGridDoc.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Образование";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Возраст";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Стаж";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Услуги";
            this.Column5.Name = "Column5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StazhDoc
            // 
            this.StazhDoc.Location = new System.Drawing.Point(306, 6);
            this.StazhDoc.Maximum = 40;
            this.StazhDoc.Minimum = 3;
            this.StazhDoc.Name = "StazhDoc";
            this.StazhDoc.Size = new System.Drawing.Size(104, 45);
            this.StazhDoc.TabIndex = 3;
            this.StazhDoc.TickStyle = System.Windows.Forms.TickStyle.None;
            this.StazhDoc.Value = 3;
            this.StazhDoc.Scroll += new System.EventHandler(this.StazhDoc_Scroll);
            // 
            // AgeDoc
            // 
            this.AgeDoc.Location = new System.Drawing.Point(170, 6);
            this.AgeDoc.Maximum = 70;
            this.AgeDoc.Minimum = 23;
            this.AgeDoc.Name = "AgeDoc";
            this.AgeDoc.Size = new System.Drawing.Size(105, 45);
            this.AgeDoc.TabIndex = 2;
            this.AgeDoc.TickStyle = System.Windows.Forms.TickStyle.None;
            this.AgeDoc.Value = 23;
            this.AgeDoc.Scroll += new System.EventHandler(this.AgeDoc_Scroll);
            // 
            // EducCB
            // 
            this.EducCB.FormattingEnabled = true;
            this.EducCB.Items.AddRange(new object[] {
            "стоматолог-терапевт",
            "Стоматолог-хирург",
            "стоматолог-гигиенист"});
            this.EducCB.Location = new System.Drawing.Point(6, 32);
            this.EducCB.Name = "EducCB";
            this.EducCB.Size = new System.Drawing.Size(121, 21);
            this.EducCB.TabIndex = 1;
            // 
            // NameDocTB
            // 
            this.NameDocTB.Location = new System.Drawing.Point(6, 6);
            this.NameDocTB.Name = "NameDocTB";
            this.NameDocTB.Size = new System.Drawing.Size(121, 20);
            this.NameDocTB.TabIndex = 0;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Стоимость";
            this.Column11.Name = "Column11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 407);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StazhDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button AddPatBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NamePatTB;
        private System.Windows.Forms.ComboBox ServicesCB;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar StazhDoc;
        private System.Windows.Forms.TrackBar AgeDoc;
        private System.Windows.Forms.ComboBox EducCB;
        private System.Windows.Forms.TextBox NameDocTB;
        private System.Windows.Forms.DataGridView DataGridDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PatPassTB;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox TypeCB;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ComboBox selectDocCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}

