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
    public partial class DeleteForm : Form
    {
        int Res;

        public DeleteForm()
        {
            InitializeComponent();

        }

        public DeleteForm(List<FamilyMember> FM)
        {
            InitializeComponent();
            comboBox_fm.Items.AddRange(FM.Select(x => x.FirstName + " " + x.LastName).ToArray());
            if(FM.Count != 0) comboBox_fm.SelectedIndex = 0;
        }

        public DeleteForm(List<InOutCome> inoutcome, bool inout)
        {
            InitializeComponent();
            comboBox_fm.Items.AddRange(inoutcome.Select(x => x.TypeName).ToArray());
            if (inoutcome.Count != 0) comboBox_fm.SelectedIndex = 0;
            if (inout)
            {
                this.Text = "Удалить источник дохода";
            }
            else this.Text = "Удалить статью расхода";
        }

        private void button_del_ok_Click(object sender, EventArgs e)
        {
            Res = comboBox_fm.SelectedIndex;
            this.DialogResult = DialogResult.OK;
        }

        public int resIndex { get { return Res; } }

        private void button_del_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
