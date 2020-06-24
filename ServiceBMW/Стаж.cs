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
    public partial class Стаж : Form
    {
        public Стаж()
        {
            InitializeComponent();
        }

        private void стажBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.стажBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bMWServiceDataSet);

        }

        private void Стаж_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bMWServiceDataSet.Стаж". При необходимости она может быть перемещена или удалена.
            this.стажTableAdapter.Fill(this.bMWServiceDataSet.Стаж);

        }
    }
}
