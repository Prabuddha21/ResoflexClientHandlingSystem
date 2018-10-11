using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.AdminForms.AdminReports
{
    public partial class Reports : MetroFramework.Forms.MetroForm
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            string query = "SELECT distinct u_name, operation, logged_in_dateTime, logged_out_dateTime  FROM user_operations o, user u, user_log l where l.user_id = u.user_id and l.log_id = o.log_id and u.u_name= '" + usercombo.SelectedItem.ToString()+"';";

            runquery(query);
        }

        private void runquery(string query)
        {
            MySqlDataReader reader;
            DataTable table = new DataTable();
            table.Columns.Add("u_name", typeof(string));
            table.Columns.Add("operation", typeof(string));
            table.Columns.Add("logged_in_dateTime", typeof(DateTime));
            table.Columns.Add("logged_out_dateTime", typeof(DateTime));

            try
            {
                reader = Core.DBConnection.getData(query);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader["u_name"].ToString(), reader["operation"].ToString(), reader["logged_in_dateTime"].ToString(), reader["logged_out_dateTime"].ToString());
                    }
                }
                reader.Close();

                Sample sample = new Sample();

                sample.Database.Tables["UserDSet"].SetDataSource(table);

                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = sample;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            

        }

        private void Report_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT u_name from  user;");

                while (reader.Read())
                {
                    usercombo.Items.Add(reader.GetValue(0).ToString());
                    uname1.Items.Add(reader.GetValue(0).ToString());

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void viewmonthly_Click(object sender, EventArgs e)
        {
            string query = "select u.u_name, l.logged_in_dateTime,  l.logged_out_dateTime, timestampdiff(MINUTE, (l.logged_in_dateTime), (l.logged_out_dateTime)) as diff from user_log l, user u, user_operations o where u.user_id = l.user_id and " +
                "l.logged_out_dateTime IS NOT NULL and l.logged_in_dateTime between '"+ from.Value.ToString("yyyy/MM/dd HH:mm:ss") +"' and '"+to.Value.ToString("yyyy/MM/dd  HH:mm:ss")+"';";

            if (from.Value > to.Value){

                MessageBox.Show("Please select a date after 'FROM date' as the 'TO date'", "Invalid TO date", MessageBoxButtons.OK);
            }
            else {

                runquery1(query);
            }
        }

        private void runquery1(string query)
        {
            MySqlDataReader reader;
            DataTable table = new DataTable();
            table.Columns.Add("u_name", typeof(string));
            table.Columns.Add("logged_in_dateTime", typeof(DateTime));
            table.Columns.Add("logged_out_dateTime", typeof(DateTime));
            table.Columns.Add("diff", typeof(int));

            try
            {
                reader = Core.DBConnection.getData(query);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader["u_name"].ToString(), reader["logged_in_dateTime"].ToString(), reader["logged_out_dateTime"].ToString(), int.Parse(reader.GetValue(3).ToString()));
                    }
                }
                reader.Close();

                MonthlyUsageReport sample = new MonthlyUsageReport();

                sample.Database.Tables["LogTable"].SetDataSource(table);

                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = sample;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string query = "select u.u_name, sum(timestampdiff(MINUTE, (l.logged_in_dateTime), (l.logged_out_dateTime))) / 60.0 as diff, sum(a.total_hours)/100.00  as work_hour_sum from user_log l, user u, user_operations o, attendance a where u.user_id = l.user_id and l.logged_out_dateTime IS NOT NULL "+ 
            "and a.staff_id = u.user_id and l.logged_in_dateTime between '" + from1.Value.ToString("yyyy/MM/dd HH:mm:ss") + "' and '" + to1.Value.ToString("yyyy/MM/dd  HH:mm:ss") + "' and a.in_time between '" + from1.Value.ToString("yyyy/MM/dd HH:mm:ss") + "' and '" + to1.Value.ToString("yyyy/MM/dd  HH:mm:ss") + "' and u.u_name= '" + uname1.SelectedItem.ToString() + "';";

            if (from1.Value > to1.Value)
            {

                MessageBox.Show("Please select a date after 'FROM date' as the 'TO date'", "Invalid TO date", MessageBoxButtons.OK);
            }
            else
            {

                runquery2(query);
            }
        }

        private void runquery2(string query)
        {
            MySqlDataReader reader;
            DataTable table = new DataTable();
            table.Columns.Add("u_name", typeof(string));
            table.Columns.Add("Total_logged_in_hours", typeof(Double));
            table.Columns.Add("Total_work_hours", typeof(Double));
            table.Columns.Add("efficiency", typeof(Double));

            try
            {
                reader = Core.DBConnection.getData(query);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader["u_name"].ToString(), Double.Parse(reader["diff"].ToString()), Double.Parse(reader["work_hour_sum"].ToString()), 100 * Double.Parse(reader["diff"].ToString()) /  Double.Parse(reader["work_hour_sum"].ToString()));
                    }
                }
                reader.Close();

                UserEfficiencyReport sample = new UserEfficiencyReport();

                sample.Database.Tables["AttedanceDSet"].SetDataSource(table);

                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = sample;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
