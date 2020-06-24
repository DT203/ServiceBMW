using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceBMW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bMWServiceDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.bMWServiceDataSet.Клиент);


        }

        private void сервисToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bMWServiceDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.bMWServiceDataSet.Клиент);
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            О_программе прог = new О_программе();
            прог.ShowDialog();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Клиент клиенты = new Клиент();
            клиенты.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void автомобильКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Автомобили авто = new Автомобили();
            авто.ShowDialog();
        }

        private void обслуживваниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Обслуживание обслуж = new Обслуживание();
            обслуж.ShowDialog();
        }

        private void сервисToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Сервис серв = new Сервис();
            серв.ShowDialog();
        }

        private void персоналСервисаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Персонал персон = new Персонал();
            персон.ShowDialog();
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Сотрудник сот = new Сотрудник();
            сот.ShowDialog();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Должность долж = new Должность();
            долж.ShowDialog();
        }

        private void стажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Стаж стж = new Стаж();
            стж.ShowDialog();
        }
    }
}
