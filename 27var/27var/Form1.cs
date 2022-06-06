using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27var
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_27varDataSet.Запрос". При необходимости она может быть перемещена или удалена.
            this.запросTableAdapter.Fill(this._27varDataSet.Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_27varDataSet.ВедомостьОПТ". При необходимости она может быть перемещена или удалена.
            this.ведомостьОПТTableAdapter.Fill(this._27varDataSet.ВедомостьОПТ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_27varDataSet.УчетПродаж". При необходимости она может быть перемещена или удалена.
            this.учетПродажTableAdapter.Fill(this._27varDataSet.УчетПродаж);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_27varDataSet.Номенклатура". При необходимости она может быть перемещена или удалена.
            this.номенклатураTableAdapter.Fill(this._27varDataSet.Номенклатура);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.номенклатураBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._27varDataSet);
            this.номенклатураTableAdapter.Fill(this._27varDataSet.Номенклатура);
            this.учетПродажTableAdapter.Fill(this._27varDataSet.УчетПродаж);
            this.ведомостьОПТTableAdapter.Fill(this._27varDataSet.ВедомостьОПТ);
            this.запросTableAdapter.Fill(this._27varDataSet.Запрос);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.учетПродажBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._27varDataSet);
            this.учетПродажTableAdapter.Fill(this._27varDataSet.УчетПродаж);
            this.номенклатураTableAdapter.Fill(this._27varDataSet.Номенклатура);
            this.ведомостьОПТTableAdapter.Fill(this._27varDataSet.ВедомостьОПТ);
            this.запросTableAdapter.Fill(this._27varDataSet.Запрос);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ведомостьОПТBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._27varDataSet);
            this.ведомостьОПТTableAdapter.Fill(this._27varDataSet.ВедомостьОПТ);
            this.номенклатураTableAdapter.Fill(this._27varDataSet.Номенклатура);
            this.учетПродажTableAdapter.Fill(this._27varDataSet.УчетПродаж);
            this.запросTableAdapter.Fill(this._27varDataSet.Запрос);
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
