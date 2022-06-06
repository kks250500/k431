using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8var
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_8varDataSet.Запрос". При необходимости она может быть перемещена или удалена.
            this.запросTableAdapter.Fill(this._8varDataSet.Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_8varDataSet.Шифр". При необходимости она может быть перемещена или удалена.
            this.шифрTableAdapter.Fill(this._8varDataSet.Шифр);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_8varDataSet.Наличие". При необходимости она может быть перемещена или удалена.
            this.наличиеTableAdapter.Fill(this._8varDataSet.Наличие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_8varDataSet.Номенклатура". При необходимости она может быть перемещена или удалена.
            this.номенклатураTableAdapter.Fill(this._8varDataSet.Номенклатура);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.номенклатураBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._8varDataSet);
            this.номенклатураTableAdapter.Fill(this._8varDataSet.Номенклатура);
            this.запросTableAdapter.Fill(this._8varDataSet.Запрос);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.наличиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._8varDataSet);
            this.наличиеTableAdapter.Fill(this._8varDataSet.Наличие);
            this.запросTableAdapter.Fill(this._8varDataSet.Запрос);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.шифрBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._8varDataSet);
            this.шифрTableAdapter.Fill(this._8varDataSet.Шифр);
            this.запросTableAdapter.Fill(this._8varDataSet.Запрос);
            this.наличиеTableAdapter.Fill(this._8varDataSet.Наличие);
            this.номенклатураTableAdapter.Fill(this._8varDataSet.Номенклатура);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.номенклатураBindingSource.Filter = "Наименование" + " LIKE '" + this.textBox1.Text + "*'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.номенклатураBindingSource.RemoveFilter();
            this.textBox1.Text = "";
        }
    }
}
