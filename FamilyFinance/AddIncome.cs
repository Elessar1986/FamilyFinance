using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyFinance
{
    public partial class AddIncome : Form
    {
        InOutCome income;

        public AddIncome()
        {
            InitializeComponent();
        }

        public AddIncome(string Text)
        {
            InitializeComponent();
            this.Text = "Добавить вид расхода";
            this.label2.Text = "Название расхода";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            income = new InOutCome();
            income.TypeName = textBox_typeName.Text;
            this.DialogResult = DialogResult.OK;
        }

        public InOutCome resInc { get { return income; } }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
