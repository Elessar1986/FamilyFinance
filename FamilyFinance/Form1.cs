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
    public partial class Form1 : Form
    {
        BaseEngine BaseEngine = new BaseEngine();

        public Form1()
        {
            InitializeComponent();
            var BaseEngine = new BaseEngine();
            ReloadFamilyMembersList();
            ReloadIncomeList();
            ReloadOutcomeList();
            ChekForCurentData();

        }

        private void familyMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FamilyMemberAddEdit add = new FamilyMemberAddEdit();
            add.ShowDialog();
            if(add.DialogResult == DialogResult.OK)
            {
                BaseEngine.AddMember(add.newMember);
                BaseEngine.GetMembers();
                ReloadFamilyMembersList();
            }
            
        }

        private void deleteFamilyMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm dfm = new DeleteForm(BaseEngine.members);
            dfm.ShowDialog();
            if(dfm.DialogResult == DialogResult.OK)
            {
                
                BaseEngine.DeleteMember(BaseEngine.members[ dfm.resIndex].MemberId);
                BaseEngine.GetMembers();
                ReloadFamilyMembersList();
            }
        }

        private void ReloadFamilyMembersList()
        {
            comboBox_fMembers.Items.Clear();
            comboBox_fMembers.Update();
            if(BaseEngine.members.Count != 0)
            {
                comboBox_fMembers.Items.AddRange(BaseEngine.members.Select(x => x.FirstName + " " + x.LastName).ToArray());
                comboBox_fMembers.SelectedIndex = 0;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ChekForCurentData();
        }

        private void add_income_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddIncome ai = new AddIncome();
            ai.ShowDialog();
            if(ai.DialogResult == DialogResult.OK)
            {
                BaseEngine.AddIncome(ai.resInc);
                ReloadIncomeList();
            }
        }

        private void ReloadIncomeList()
        {
            BaseEngine.GetIncome();
            comboBox_incomeTypes.Items.Clear();
            if (BaseEngine.income.Count != 0)
            {
                foreach (var item in BaseEngine.income)
                {
                    comboBox_incomeTypes.Items.Add(item.TypeName);
                    
                }
                comboBox_incomeTypes.SelectedIndex = 0;
            }
        }

        private void add_outcome_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddIncome ai = new AddIncome("out");
            ai.ShowDialog();
            if (ai.DialogResult == DialogResult.OK)
            {
                BaseEngine.AddOutcome(ai.resInc);
                ReloadOutcomeList();
            }
        }

        private void ReloadOutcomeList()
        {
            BaseEngine.GetOutcome();
            comboBox_outcomeTypes.Items.Clear();
            if (BaseEngine.outcome.Count != 0)
            {
                foreach (var item in BaseEngine.outcome)
                {
                    comboBox_outcomeTypes.Items.Add(item.TypeName);
                    
                }
                comboBox_outcomeTypes.SelectedIndex = 0;
            }
        }

        private void about_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\"Семейный бюджет\"\n\nИнтелектуальная собственность Арепьева И.Ю.","О приложении",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private DateTime GetCurentDate()
        {
            DateTime curDate = dateTimePicker1.Value;
            //MessageBox.Show(curDate.AddDays(-DateTime.Now.Day + 1).ToShortDateString());
            return curDate.AddDays(-DateTime.Now.Day + 1);
        }

        private int GetIncomeIndex()
        {
            if (comboBox_incomeTypes.SelectedIndex != -1) return BaseEngine.income[comboBox_incomeTypes.SelectedIndex].Id;
            else return 0;
        }

        private int GetOutcomeIndex()
        {
            if (comboBox_outcomeTypes.SelectedIndex != -1) return BaseEngine.outcome[comboBox_outcomeTypes.SelectedIndex].Id;
            else return 0;
        }


        private int GetMemberIndex()
        {
            if (comboBox_fMembers.SelectedIndex != -1) return BaseEngine.members[comboBox_fMembers.SelectedIndex].MemberId;
            else return 0;
        }


        private void ChekForCurentData()
        {
            DateTime curDate = GetCurentDate();
            int member = GetMemberIndex();
            int inindex = GetIncomeIndex();
            int outindex = GetOutcomeIndex();
            if (BaseEngine.GetDataByDateAndIncomeType(curDate,inindex,member) == 1)
            {
                sum_income_numericUpDown1.Value = BaseEngine.inData[0];
                button_add.Enabled = false;
                button_edit.Enabled = true;
            }
            else {
                sum_income_numericUpDown1.Value = 0;
                button_add.Enabled = true;
                button_edit.Enabled = false;
            }
            if (BaseEngine.GetDataByDateAndOutcomeType(curDate, outindex, member) == 1)
            {
                numericUpDown_outcome_value.Value = BaseEngine.outData[0];
                button_add_outcome.Enabled = false;
                button_edit_outcome.Enabled = true;
            }
            else {
                numericUpDown_outcome_value.Value = 0;
                button_add_outcome.Enabled = true;
                button_edit_outcome.Enabled = false;
            }
            decimal PersInMon = BaseEngine.GetPerInMon(member, curDate);
            decimal PersOutMon = BaseEngine.GetPerOutMon(member, curDate);
            labelPersInMon.Text = PersInMon.ToString() ;
            labelPersOutMon.Text = PersOutMon.ToString();
            labelPerResMon.Text = (PersInMon + PersOutMon).ToString();
            decimal AllInMon = BaseEngine.GetAllInMon(curDate);
            decimal AllOutMon = BaseEngine.GetAllOutMon(curDate);
            labelAllInMon.Text = AllInMon.ToString();
            labelAllOutMon.Text = AllOutMon.ToString();
            labelAllResMon.Text = (AllInMon + AllOutMon).ToString();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            BaseEngine.AddIncomeData(GetCurentDate(), GetIncomeIndex(), GetMemberIndex(), sum_income_numericUpDown1.Value);
            ChekForCurentData();
        }

        private void comboBox_incomeTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChekForCurentData();
        }

        private void comboBox_fMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChekForCurentData();
        }

        private void del_income_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm df = new DeleteForm(BaseEngine.income, true);
            df.ShowDialog();
            if (df.DialogResult == DialogResult.OK)
            {
                BaseEngine.DeleteIncome(BaseEngine.income[df.resIndex].Id);
                ReloadIncomeList();
                ChekForCurentData();
            }
        }

        private void del_outcome_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm df = new DeleteForm(BaseEngine.outcome, false);
            df.ShowDialog();
            if (df.DialogResult == DialogResult.OK)
            {
                BaseEngine.DeleteOutcome(BaseEngine.outcome[df.resIndex].Id);
                ReloadOutcomeList();
                ChekForCurentData();
            }
        }

        private void button_add_outcome_Click(object sender, EventArgs e)
        {
            BaseEngine.AddOutcomeData(GetCurentDate(), GetOutcomeIndex(), GetMemberIndex(), numericUpDown_outcome_value.Value);
            ChekForCurentData();
        }

        private void comboBox_outcomeTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChekForCurentData();
        }

        private void ed_members_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FamilyMember fm = BaseEngine.members[comboBox_fMembers.SelectedIndex];
            FamilyMemberAddEdit fme = new FamilyMemberAddEdit(fm);
            fme.ShowDialog();
            if (fme.DialogResult == DialogResult.OK)
            {
                BaseEngine.UpdateFamilyMember(fme.newMember);
                BaseEngine.GetMembers();
                ReloadFamilyMembersList();
            }
        }

        private void button_edit_outcome_Click(object sender, EventArgs e)
        {
            BaseEngine.UpdateOutcomeData(GetCurentDate(), GetOutcomeIndex(), GetMemberIndex(), numericUpDown_outcome_value.Value);
            ChekForCurentData();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            BaseEngine.UpdateIncomeData(GetCurentDate(), GetIncomeIndex(), GetMemberIndex(), sum_income_numericUpDown1.Value);
            ChekForCurentData();
        }
    }
}
