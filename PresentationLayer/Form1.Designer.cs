namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menadžer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbKategorije = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1SviProjekti = new System.Windows.Forms.TabPage();
            this.tabPage2DodajProjekt = new System.Windows.Forms.TabPage();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.button1Spremi = new System.Windows.Forms.Button();
            this.textBox3Opis = new System.Windows.Forms.TextBox();
            this.textBox2Naziv = new System.Windows.Forms.TextBox();
            this.label6Rok = new System.Windows.Forms.Label();
            this.label5Kategorija = new System.Windows.Forms.Label();
            this.label4Manager = new System.Windows.Forms.Label();
            this.label3Opis = new System.Windows.Forms.Label();
            this.label2Name = new System.Windows.Forms.Label();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1SviProjekti.SuspendLayout();
            this.tabPage2DodajProjekt.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.Opis,
            this.Menadžer,
            this.Kategorija,
            this.Rok});
            this.dataGridView1.Location = new System.Drawing.Point(169, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "name";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "description";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            // 
            // Menadžer
            // 
            this.Menadžer.DataPropertyName = "managerFullName";
            this.Menadžer.HeaderText = "Menadžer";
            this.Menadžer.Name = "Menadžer";
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "category";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.Name = "Kategorija";
            // 
            // Rok
            // 
            this.Rok.DataPropertyName = "deadline";
            this.Rok.HeaderText = "Krajnji Rok";
            this.Rok.Name = "Rok";
            // 
            // cbKategorije
            // 
            this.cbKategorije.FormattingEnabled = true;
            this.cbKategorije.Location = new System.Drawing.Point(42, 6);
            this.cbKategorije.Name = "cbKategorije";
            this.cbKategorije.Size = new System.Drawing.Size(121, 21);
            this.cbKategorije.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(169, 384);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(136, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Dodaj novi projekt";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1SviProjekti);
            this.tabControl1.Controls.Add(this.tabPage2DodajProjekt);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(955, 439);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1SviProjekti
            // 
            this.tabPage1SviProjekti.Controls.Add(this.BtnAdd);
            this.tabPage1SviProjekti.Controls.Add(this.cbKategorije);
            this.tabPage1SviProjekti.Controls.Add(this.dataGridView1);
            this.tabPage1SviProjekti.Location = new System.Drawing.Point(4, 22);
            this.tabPage1SviProjekti.Name = "tabPage1SviProjekti";
            this.tabPage1SviProjekti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1SviProjekti.Size = new System.Drawing.Size(947, 413);
            this.tabPage1SviProjekti.TabIndex = 0;
            this.tabPage1SviProjekti.Text = "Svi Projekti";
            this.tabPage1SviProjekti.UseVisualStyleBackColor = true;
            // 
            // tabPage2DodajProjekt
            // 
            this.tabPage2DodajProjekt.Controls.Add(this.dateTimePickerDeadline);
            this.tabPage2DodajProjekt.Controls.Add(this.comboBoxCategory);
            this.tabPage2DodajProjekt.Controls.Add(this.comboBoxManager);
            this.tabPage2DodajProjekt.Controls.Add(this.button1Spremi);
            this.tabPage2DodajProjekt.Controls.Add(this.textBox3Opis);
            this.tabPage2DodajProjekt.Controls.Add(this.textBox2Naziv);
            this.tabPage2DodajProjekt.Controls.Add(this.label6Rok);
            this.tabPage2DodajProjekt.Controls.Add(this.label5Kategorija);
            this.tabPage2DodajProjekt.Controls.Add(this.label4Manager);
            this.tabPage2DodajProjekt.Controls.Add(this.label3Opis);
            this.tabPage2DodajProjekt.Controls.Add(this.label2Name);
            this.tabPage2DodajProjekt.Location = new System.Drawing.Point(4, 22);
            this.tabPage2DodajProjekt.Name = "tabPage2DodajProjekt";
            this.tabPage2DodajProjekt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2DodajProjekt.Size = new System.Drawing.Size(947, 413);
            this.tabPage2DodajProjekt.TabIndex = 1;
            this.tabPage2DodajProjekt.Text = "Dodaj Projekt";
            this.tabPage2DodajProjekt.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(145, 140);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCategory.TabIndex = 15;
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Location = new System.Drawing.Point(145, 110);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(213, 21);
            this.comboBoxManager.TabIndex = 14;
            // 
            // button1Spremi
            // 
            this.button1Spremi.Location = new System.Drawing.Point(76, 212);
            this.button1Spremi.Name = "button1Spremi";
            this.button1Spremi.Size = new System.Drawing.Size(116, 33);
            this.button1Spremi.TabIndex = 12;
            this.button1Spremi.Text = "Spremi";
            this.button1Spremi.UseVisualStyleBackColor = true;
            this.button1Spremi.Click += new System.EventHandler(this.button1Spremi_Click);
            // 
            // textBox3Opis
            // 
            this.textBox3Opis.Location = new System.Drawing.Point(145, 78);
            this.textBox3Opis.Name = "textBox3Opis";
            this.textBox3Opis.Size = new System.Drawing.Size(100, 20);
            this.textBox3Opis.TabIndex = 8;
            // 
            // textBox2Naziv
            // 
            this.textBox2Naziv.Location = new System.Drawing.Point(145, 52);
            this.textBox2Naziv.Name = "textBox2Naziv";
            this.textBox2Naziv.Size = new System.Drawing.Size(100, 20);
            this.textBox2Naziv.TabIndex = 7;
            // 
            // label6Rok
            // 
            this.label6Rok.AutoSize = true;
            this.label6Rok.Location = new System.Drawing.Point(42, 174);
            this.label6Rok.Name = "label6Rok";
            this.label6Rok.Size = new System.Drawing.Size(58, 13);
            this.label6Rok.TabIndex = 5;
            this.label6Rok.Text = "Krajnji Rok";
            // 
            // label5Kategorija
            // 
            this.label5Kategorija.AutoSize = true;
            this.label5Kategorija.Location = new System.Drawing.Point(42, 148);
            this.label5Kategorija.Name = "label5Kategorija";
            this.label5Kategorija.Size = new System.Drawing.Size(54, 13);
            this.label5Kategorija.TabIndex = 4;
            this.label5Kategorija.Text = "Kategorija";
            // 
            // label4Manager
            // 
            this.label4Manager.AutoSize = true;
            this.label4Manager.Location = new System.Drawing.Point(42, 118);
            this.label4Manager.Name = "label4Manager";
            this.label4Manager.Size = new System.Drawing.Size(54, 13);
            this.label4Manager.TabIndex = 3;
            this.label4Manager.Text = "Menadžer";
            // 
            // label3Opis
            // 
            this.label3Opis.AutoSize = true;
            this.label3Opis.Location = new System.Drawing.Point(42, 89);
            this.label3Opis.Name = "label3Opis";
            this.label3Opis.Size = new System.Drawing.Size(28, 13);
            this.label3Opis.TabIndex = 2;
            this.label3Opis.Text = "Opis";
            // 
            // label2Name
            // 
            this.label2Name.AutoSize = true;
            this.label2Name.Location = new System.Drawing.Point(42, 59);
            this.label2Name.Name = "label2Name";
            this.label2Name.Size = new System.Drawing.Size(34, 13);
            this.label2Name.TabIndex = 1;
            this.label2Name.Text = "Naziv";
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(145, 174);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDeadline.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 558);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1SviProjekti.ResumeLayout(false);
            this.tabPage2DodajProjekt.ResumeLayout(false);
            this.tabPage2DodajProjekt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menadžer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rok;
        private System.Windows.Forms.ComboBox cbKategorije;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1SviProjekti;
        private System.Windows.Forms.TabPage tabPage2DodajProjekt;
        private System.Windows.Forms.Button button1Spremi;
        private System.Windows.Forms.TextBox textBox3Opis;
        private System.Windows.Forms.TextBox textBox2Naziv;
        private System.Windows.Forms.Label label6Rok;
        private System.Windows.Forms.Label label5Kategorija;
        private System.Windows.Forms.Label label4Manager;
        private System.Windows.Forms.Label label3Opis;
        private System.Windows.Forms.Label label2Name;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
    }
}

