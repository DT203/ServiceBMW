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
    public partial class Персонал : Form
    {
        public Персонал()
        {
            InitializeComponent();
        }

        private void персонал_СервисаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.персонал_СервисаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bMWServiceDataSet);

        }

        private void Персонал_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bMWServiceDataSet.Персонал_Сервиса". При необходимости она может быть перемещена или удалена.
            this.персонал_СервисаTableAdapter.Fill(this.bMWServiceDataSet.Персонал_Сервиса);

        }
    }
}
