using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7var
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_7varDataSet.Запрос". При необходимости она может быть перемещена или удалена.
            this.запросTableAdapter.Fill(this._7varDataSet.Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_7varDataSet.Ценники". При необходимости она может быть перемещена или удалена.
            this.ценникиTableAdapter.Fill(this._7varDataSet.Ценники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_7varDataSet.Нормирование". При необходимости она может быть перемещена или удалена.
            this.нормированиеTableAdapter.Fill(this._7varDataSet.Нормирование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_7varDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this._7varDataSet.Продукты);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.продуктыBindingSource.EndEdit();
            this.продуктыTableAdapter.Update(this._7varDataSet);
            this.продуктыTableAdapter.Fill(this._7varDataSet.Продукты);
            this.запросTableAdapter.Fill(this._7varDataSet.Запрос);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.нормированиеBindingSource.EndEdit();
            this.нормированиеTableAdapter.Update(this._7varDataSet);
            this.нормированиеTableAdapter.Fill(this._7varDataSet.Нормирование);
            this.запросTableAdapter.Fill(this._7varDataSet.Запрос);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ценникиBindingSource.EndEdit();
            this.ценникиTableAdapter.Update(this._7varDataSet);
            this.ценникиTableAdapter.Fill(this._7varDataSet.Ценники);
            this.запросTableAdapter.Fill(this._7varDataSet.Запрос);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            продуктыBindingSource.Filter = "Наименование" + " LIKE '" + this.textBox1.Text + "*'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            продуктыBindingSource.RemoveFilter();
            this.textBox1.Text = "";
        }
    }
}
