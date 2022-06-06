using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20var
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "var20DataSet.Сумма". При необходимости она может быть перемещена или удалена.
            this.суммаTableAdapter.Fill(this.var20DataSet.Сумма);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "var20DataSet.Справочник". При необходимости она может быть перемещена или удалена.
            this.справочникTableAdapter.Fill(this.var20DataSet.Справочник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "var20DataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.var20DataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "var20DataSet.Ведомость". При необходимости она может быть перемещена или удалена.
            this.ведомостьTableAdapter.Fill(this.var20DataSet.Ведомость);
            /*// TODO: данная строка кода позволяет загрузить данные в таблицу "_20varDataSet.Сумма". При необходимости она может быть перемещена или удалена.
            this.суммаTableAdapter.Fill(this._20varDataSet.Сумма);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_20varDataSet.Справочник". При необходимости она может быть перемещена или удалена.
            this.справочникTableAdapter.Fill(this._20varDataSet.Справочник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_20varDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this._20varDataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_20varDataSet.Ведомость". При необходимости она может быть перемещена или удалена.
            this.ведомостьTableAdapter.Fill(this._20varDataSet.Ведомость);*/

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ведомостьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.var20DataSet);
            this.ведомостьTableAdapter.Fill(this.var20DataSet.Ведомость);
            this.суммаTableAdapter.Fill(this.var20DataSet.Сумма);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.продуктыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.var20DataSet);
            this.продуктыTableAdapter.Fill(this.var20DataSet.Продукты);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.справочникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.var20DataSet);
            this.справочникTableAdapter.Fill(this.var20DataSet.Справочник);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                ведомостьBindingSource.Filter = "Код_ведомости" + "=" + this.textBox1.Text;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                ведомостьBindingSource.Filter = "Код_продукта" + " LIKE '" + this.textBox1.Text + "*'";
            }
            /*else if (comboBox1.SelectedIndex == 2)
            {
                ведомостьBindingSource.Filter = this.comboBox1.Text + "=" + this.textBox1.Text;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                ведомостьBindingSource.Filter = this.comboBox1.Text + "=" + this.textBox1.Text;
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ведомостьBindingSource.RemoveFilter();
            this.textBox1.Text = "";
        }
    }
}
