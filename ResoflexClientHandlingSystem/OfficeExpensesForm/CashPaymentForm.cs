using System;
using ResoflexClientHandlingSystem.Role;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.OfficeExpensesForm;
using ResoflexClientHandlingSystem.Common;

namespace ResoflexClientHandlingSystem.OfficeExpenses
{
   
    public partial class CashPaymentForm : MetroFramework.Forms.MetroForm
    {
        String expType;
        String Category;
        double Amount;
        int offExpenseId;
        Staff StaffIssued;

        public CashPaymentForm()
        {
            InitializeComponent();
            //fillExpenseTypecmbBox;
            /*int offExpenseId = int.Parse(expid.Text.ToString());
            int staffIssued = int.Parse(staffid.Text.ToString());
            string category_type = category.Text;
            int Amount = int.Parse(amount.Text.ToString());
            DateTime date = datetime.Value;*/
            MySqlDataReader rdr1 = DBConnection.getData("select staff_id, first_name from staff");

            DataTable dt = new DataTable();
            dt.Load(rdr1);

           combo.DataSource = dt;
            combo.ValueMember = "staff_id";
            combo.DisplayMember = "first_name";

        }

        public CashPaymentForm(int Expense_id,int staff_id)
        {
            InitializeComponent();
            //fillExpenseTypecmbBox;

        }

        private void CashPaymentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            Role.OfficeExpenses exp = new Role.OfficeExpenses();

            exp.ExpType = type.Text.ToString();
            //exp.OffExpenseId = int.Parse(expid.Text.ToString());
            exp.StaffIssued = new Staff(int.Parse(combo.SelectedValue.ToString()));
           


            if (Validation.isNumber(inAmount.Text))
            {
                exp.Amount = int.Parse(inAmount.Text.ToString());
                exp.Category = category.Text.ToString();
                Database.addOfficeExp(exp);

                this.Close();
            }
            else
            {
                MessageBox.Show("Something went worng","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
           
        }
                
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void view_Click(object sender, EventArgs e)
        {
            OfficeReportForm re = new OfficeReportForm();
            re.Show();
        }
    }
}
