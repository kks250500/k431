using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5var
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5varDataSet.Сумма". При необходимости она может быть перемещена или удалена.
            this.суммаTableAdapter.Fill(this._5varDataSet.Сумма);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5varDataSet.Ревизия". При необходимости она может быть перемещена или удалена.
            this.ревизияTableAdapter.Fill(this._5varDataSet.Ревизия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5varDataSet.Накладная". При необходимости она может быть перемещена или удалена.
            this.накладнаяTableAdapter.Fill(this._5varDataSet.Накладная);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5varDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this._5varDataSet.Товары);

        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._5varDataSet);
            this.товарыTableAdapter.Fill(this._5varDataSet.Товары);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.накладнаяBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._5varDataSet);
            this.накладнаяTableAdapter.Fill(this._5varDataSet.Накладная);
            this.суммаTableAdapter.Fill(this._5varDataSet.Сумма);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ревизияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._5varDataSet);
            this.ревизияTableAdapter.Fill(this._5varDataSet.Ревизия);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            товарыBindingSource.Filter = "Наименование" + " LIKE '" + this.textBox1.Text + "*'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            товарыBindingSource.RemoveFilter();
            this.textBox1.Text = "";
        }
    }
}
