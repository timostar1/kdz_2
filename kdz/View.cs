using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kdz
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            
            openFileDialog.FileOk += OpenFileDialog_FileOk;
            openFileDialog.Disposed += OpenFileDialog_Disposed;
            
            // Новый файл
            this.newToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            // Открыть файл
            this.openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // Сохранить файл
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // Сохранить файл как
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // Добавить машину в список
            this.addNewCarToolStripMenuItem.Enabled = false;
            this.addNewCarToolStripMenuItem.Click += AddNewCarToolStripMenuItem_Click;
            // Помощь
            this.helpToolStripMenuItem.Click += HelpToolStripMenuItem_Click;

            // ДАННЫЕ
            this.carBindingSource.DataSource = Jarvis.Cars;
            this.dataGridView.Enabled = false;
            this.dataGridView.CellValueChanged += DataGridView_CellValueChanged;
            //this.dataGridView1.CellFormatting += DataGridView1_CellFormatting;

            Jarvis.NewFileCreated += Jarvis_NewFileCreated;
            Jarvis.CarAdded += Jarvis_CarAdded;
        }

        

        // =============================================================================================
        // Обработчики событий КОНТРОЛЛЕРА
        // =============================================================================================
        private void Jarvis_NewFileCreated()
        {
            this.Text = "New";
            this.dataGridView.Enabled = true;
            this.carBindingSource.DataSource = Jarvis.Cars;
            // Разрешаем сохранить файл как...
            this.saveAsToolStripMenuItem.Enabled = true;
            // Разрешаем добавлять строки в таблицу
            this.addNewCarToolStripMenuItem.Enabled = true;
        }

        private void Jarvis_CarAdded()
        {
            this.carBindingSource.ResetBindings(false);
        }
        // =============================================================================================
        // Обработчики событий МЕНЮ
        // =============================================================================================
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jarvis.OnNewFileCreated();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Name = "xxx";
            this.openFileDialog.ShowDialog();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jarvis.OnCarAdded();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.carBindingSource.Add(new Model.Car());
            Model.Car car = new Model.Car();
        }

        // =============================================================================================
        // Обработчики событий ФАЙЛОВ
        // =============================================================================================
        private void OpenFileDialog_Disposed(object sender, EventArgs e)
        {
            this.Name = "xxx";
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            this.Text = openFileDialog.FileName;
        }

        // =============================================================================================
        // Обработчики событий ТАБЛИЦЫ
        // =============================================================================================
        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView.CurrentCell.Value = "njknjkn";
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //labelFileInfo.Text = e.Value.ToString();
            Text = "xxxxxx";
        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Изменяем подпись на главном окне
            this.Text = this.Text[0] == '*' ? this.Text : "*" + this.Text;
        }

    }
}
