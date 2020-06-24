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
    public partial class Должность : Form
    {
        public Должность()
        {
            InitializeComponent();
        }

        private void должностьBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bMWServiceDataSet);

        }

        private void Должность_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bMWServiceDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.bMWServiceDataSet.Должность);

        }
    }
}
