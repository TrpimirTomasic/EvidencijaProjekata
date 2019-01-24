using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DataAcessLayer;
using DataAccessLayer.Entities;
using DataAcessLayer.ViewModels;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        ProjectVM _project = new ProjectVM(); 
        public ProjectRepository _projectRepository = new ProjectRepository();
        public EmployeeRepository _employeeRepository = new EmployeeRepository();
        public CategoryRepository _categoryRepository = new CategoryRepository();
        private BindingSource _categoriesBindingSource = new BindingSource();
        private BindingSource _managersBindingSource = new BindingSource();
        public Form1()
        {

            _categoriesBindingSource.DataSource = _categoryRepository.GetAllCategories();
            _managersBindingSource.DataSource = _employeeRepository.GetEmployees();

            InitializeComponent(); 


            DataGridViewImageColumn oEditButton = new DataGridViewImageColumn();
            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("D:/Projekt/EvidencijaProjekata/rubbish-bin.png");
            oEditButton.Image = Image.FromFile("D:/Projekt/EvidencijaProjekata/pencil.png");
            oDeleteButton.Width = 50;
            oEditButton.Width = 50;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            oEditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns.Add(oDeleteButton);
            dataGridView1.Columns.Add(oEditButton);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Rows.Add(Environment.NewLine);
          
        
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            dataGridView1.DataSource = _projectRepository.GetProjectsForView();           
            cbKategorije.DataSource = _categoryRepository.GetCategoriesName();
            comboBoxManager.DataSource = _managersBindingSource;
            comboBoxManager.ValueMember = "id";
            comboBoxManager.DisplayMember = "name";
            comboBoxCategory.DataSource = _categoriesBindingSource;
            comboBoxCategory.ValueMember = "id";
            comboBoxCategory.DisplayMember = "name";
            dateTimePickerDeadline.CustomFormat = "yyyy-MM-dd";

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2DodajProjekt");
        }

        private void button1Spremi_Click(object sender, EventArgs e)
        {
            var selectedManagerId = comboBoxManager.SelectedValue;
            var selectedCategoryID = comboBoxCategory.SelectedValue;
            
            
            Project noviProjekt = new Project();
            noviProjekt.name = textBox2Naziv.Text;
            noviProjekt.description = textBox3Opis.Text;
            noviProjekt.manager = (int)selectedManagerId;
            noviProjekt.category =(int)selectedCategoryID;
            string deadline = $"{dateTimePickerDeadline.Value.Year}-{dateTimePickerDeadline.Value.Month}-{dateTimePickerDeadline.Value.Day}";

            _projectRepository.AddProject(noviProjekt, deadline); 
            ProjectRepository oPr = new ProjectRepository();
            dataGridView1.DataSource = oPr.GetProjectsForView();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Selected = true; // trazi se koja celija je odabrana
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1) 
            {
                string ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string Naziv = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string Opis = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string Menadzer = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string Kategorija = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string Rok = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                Project oProject = new Project()
                {
                    id = Int32.Parse(ID),
                    name = Naziv,
                    description = Opis,
                    manager = _employeeRepository.GetEmployeeID(Menadzer),
                    category = _categoryRepository.GetCategoryID(Kategorija),
                    deadline = DateTime.Parse(Rok),
                };
                _projectRepository.DeleteProject(oProject);
                ProjectRepository oPr = new ProjectRepository();
                dataGridView1.DataSource = oPr.GetProjectsForView();
            }


            if (dataGridView1.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                string ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string Naziv = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string Opis = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string Menadzer = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string Kategorija = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string Rok = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                Project oProject = new Project()
                {
                    id = Int32.Parse(ID),
                    name = Naziv,
                    description = Opis,
                    manager = _employeeRepository.GetEmployeeID(Menadzer),
                    category = _categoryRepository.GetCategoryID(Kategorija),
                    deadline = DateTime.Parse(Rok),
                };
            }
        }
    }
}
