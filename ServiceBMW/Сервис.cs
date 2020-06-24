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
    public partial class Сервис : Form
    {
        public Сервис()
        {
            InitializeComponent();
        }

        private void сервисBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сервисBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bMWServiceDataSet);

        }

        private void Сервис_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bMWServiceDataSet.Сервис". При необходимости она может быть перемещена или удалена.
            this.сервисTableAdapter.Fill(this.bMWServiceDataSet.Сервис);

        }
    }
}
