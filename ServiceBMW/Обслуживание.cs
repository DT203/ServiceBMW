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
    public partial class Обслуживание : Form
    {
        public Обслуживание()
        {
            InitializeComponent();
        }

        private void обслуживаниеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.обслуживаниеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bMWServiceDataSet);

        }

        private void Обслуживание_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bMWServiceDataSet.Обслуживание". При необходимости она может быть перемещена или удалена.
            this.обслуживаниеTableAdapter.Fill(this.bMWServiceDataSet.Обслуживание);

        }
    }
}
