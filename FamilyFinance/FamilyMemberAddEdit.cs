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
    public partial class FamilyMemberAddEdit : Form
    {

        FamilyMember familyMember = new FamilyMember();

        public FamilyMemberAddEdit()
        {
            InitializeComponent();
        }

        public FamilyMemberAddEdit(FamilyMember fm)
        {
            InitializeComponent();
            this.Text = "Изменить";
            button_add.Text = "Изменить";
            textBox_firstName.Text = fm.FirstName;
            textBox_lastName.Text = fm.LastName;
            familyMember.MemberId = fm.MemberId;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            familyMember.FirstName = textBox_firstName.Text;
            familyMember.LastName = textBox_lastName.Text;
            this.DialogResult = DialogResult.OK;
        }

        public FamilyMember newMember { get { return familyMember; }  }

        private void textBox_firstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
