using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace FamilyFinance
{
    class BaseEngine
    {
        //string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Financial.mdf;Integrated Security=True";
        //string connectionStr = @"Data Source=ELESSAR-ПК;Initial Catalog=MyFinance;Integrated Security=True;Pooling=False";
        string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MyFinance.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader reader;

        public List<FamilyMember> members = new List<FamilyMember>();
        public List<InOutCome> income = new List<InOutCome>();
        public List<InOutCome> outcome = new List<InOutCome>();
        public List<decimal> inData = new List<decimal>();
        public List<decimal> outData = new List<decimal>();



        public BaseEngine()
        {
            GetMembers();
            GetIncome();
        }

        public void AddOutcome(InOutCome inc)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("AddOutcome", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@TypeName", inc.TypeName);
                    int n = comm.ExecuteNonQuery();
                    //MessageBox.Show(n.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AddIncome(InOutCome inc)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("AddIncome", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@TypeName", inc.TypeName);
                    int n = comm.ExecuteNonQuery();
                    //MessageBox.Show(n.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void GetOutcome()
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("GetOutcome", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    reader = comm.ExecuteReader();
                    outcome.Clear();
                    while (reader.Read())
                    {
                        outcome.Add(new InOutCome(reader.GetInt32(0), reader.GetString(1).TrimEnd()));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void GetIncome()
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("GetIncome", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    reader = comm.ExecuteReader();
                    income.Clear();
                    while (reader.Read())
                    {
                        income.Add(new InOutCome(reader.GetInt32(0), reader.GetString(1).TrimEnd()));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public decimal GetAllOutMon(DateTime curDate)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("GetAllOutMon", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@CurDate", curDate);
                    decimal res = Convert.ToDecimal(comm.ExecuteScalar());
                    return res;
                }
                catch (Exception e)
                {
                    return 0;
                }
            }
        }

        public decimal GetAllInMon( DateTime curDate)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("GetAllInMon", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@CurDate", curDate);
                    decimal res = Convert.ToDecimal(comm.ExecuteScalar());
                    return res;
                }
                catch (Exception e)
                {
                    return 0;
                }
            }
        }

        public decimal GetPerOutMon(int MemberId, DateTime curDate)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("GetPerOutMon", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@MemberId", MemberId);
                    comm.Parameters.AddWithValue("@CurDate", curDate);
                    decimal res = Convert.ToDecimal(comm.ExecuteScalar());
                    return res;

                }
                catch (Exception e)
                {
                    return 0;
                }
            }
        }

        public decimal GetPerInMon(int MemberId, DateTime curDete)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("GetPerInMon", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@MemberId", MemberId);
                    comm.Parameters.AddWithValue("@CurDete", curDete);
                    decimal res = Convert.ToDecimal( comm.ExecuteScalar());
                    return res;
                    
                }
                catch (Exception e)
                {
                    //MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }

        public void GetMembers()
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("GetFamilyMember", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    reader = comm.ExecuteReader();
                    members.Clear();
                    while (reader.Read())
                    {
                        members.Add(new FamilyMember(reader.GetString(1).TrimEnd(), reader.GetString(2).TrimEnd(), reader.GetInt32(0)));
                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AddMember(FamilyMember fm)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("AddFamilyMember", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@FirstName", fm.FirstName);
                    comm.Parameters.AddWithValue("@LastName", fm.LastName);
                    int n = comm.ExecuteNonQuery();
                    //MessageBox.Show(n.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void DeleteIncome(int Index)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("DelIncom", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@IncomeId", Index);
                    int n = comm.ExecuteNonQuery();
                    //MessageBox.Show(n.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void DeleteOutcome(int Index)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("DelOutCome", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@OutcomeId", Index);
                    int n = comm.ExecuteNonQuery();
                    //MessageBox.Show(n.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void DeleteMember(int Index)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("DeleteFamilyMember", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@MemberId", Index);
                    int n = comm.ExecuteNonQuery();
                    //MessageBox.Show(n.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public int GetDataByDateAndIncomeType(DateTime curDate, int IncomeId, int MemberId)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("GetIncomeByDateAndType", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@CurDate", curDate);
                    comm.Parameters.AddWithValue("@IncomeType", IncomeId);
                    comm.Parameters.AddWithValue("@MemberId", MemberId);
                    reader = comm.ExecuteReader();
                    inData.Clear();
                    while (reader.Read())
                    {
                        inData.Add(reader.GetDecimal(0));
                    }
                    return inData.Count;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message} {e.Source}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }

        }

        public int GetDataByDateAndOutcomeType(DateTime curDate, int OutcomeId, int MemberId)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("GetOutcomeByDateAndType", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@CurDate", curDate);
                    comm.Parameters.AddWithValue("@OutcomeType", OutcomeId);
                    comm.Parameters.AddWithValue("@MemberId", MemberId);
                    reader = comm.ExecuteReader();
                    outData.Clear();
                    while (reader.Read())
                    {
                        outData.Add(reader.GetDecimal(0));
                    }
                    return outData.Count;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }

        }

        public void AddIncomeData(DateTime curDate, int IncomeId, int MemberId, decimal Value)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("AddMainIncome", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@MemberId", MemberId);
                    comm.Parameters.AddWithValue("@IncomeId", IncomeId);
                    comm.Parameters.AddWithValue("@IncomeValue", Value);
                    comm.Parameters.AddWithValue("@DateOfIncome", curDate);
                    int n = comm.ExecuteNonQuery();
                    //MessageBox.Show(n.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdateIncomeData(DateTime curDate, int IncomeId, int MemberId, decimal Value)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("UpdateMainIncome", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@MemberId", MemberId);
                    comm.Parameters.AddWithValue("@IncomeId", IncomeId);
                    comm.Parameters.AddWithValue("@IncomeValue", Value);
                    comm.Parameters.AddWithValue("@DateOfIncome", curDate);
                    int n = comm.ExecuteNonQuery();
                    //MessageBox.Show(n.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdateOutcomeData(DateTime curDate, int OutcomeId, int MemberId, decimal Value)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("UpdateMainOutcome", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@MemberId", MemberId);
                    comm.Parameters.AddWithValue("@OutcomeId", OutcomeId);
                    comm.Parameters.AddWithValue("@OutcomeValue", Value);
                    comm.Parameters.AddWithValue("@DateOfOutcome", curDate);
                    int n = comm.ExecuteNonQuery();
                    //MessageBox.Show(n.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AddOutcomeData(DateTime curDate, int OutcomeId, int MemberId, decimal Value)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("AddMainOutcome", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@MemberId", MemberId);
                    comm.Parameters.AddWithValue("@OutcomeId", OutcomeId);
                    comm.Parameters.AddWithValue("@OutcomeValue", Value);
                    comm.Parameters.AddWithValue("@DateOfOutcome", curDate);
                    int n = comm.ExecuteNonQuery();
                    //MessageBox.Show(n.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public int UpdateFamilyMember(FamilyMember fm)
        {
            using (conn = new SqlConnection(connectionStr))
            {
                try
                {
                    conn.Open();
                    comm = new SqlCommand("UpdateFamilyMember", conn);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@MemberId", fm.MemberId);
                    comm.Parameters.AddWithValue("@FirstName", fm.FirstName);
                    comm.Parameters.AddWithValue("@LastName", fm.LastName);
                    int n = comm.ExecuteNonQuery();
                    //MessageBox.Show(n.ToString());
                    return n;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ошибка соединения с базой: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
        }


    }
}
