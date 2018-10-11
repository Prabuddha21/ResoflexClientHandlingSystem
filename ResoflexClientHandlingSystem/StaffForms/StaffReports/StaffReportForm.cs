using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.StaffForms.StaffReports
{
    public partial class StaffReportForm : MetroFramework.Forms.MetroForm
    {
        int tId;
        string sId;
        string tsk;
        string a, u;
        DateTime at, ut;
        TimeSpan dif;

        public StaffReportForm()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void Report_Click(object sender, EventArgs e)
        {
            string qry = "select event_tech_id,task,appointed_time,used_time from event_technician_task where event_tech_id = " + tId + "";
            //string qry2 = "select appointed_time-used_time from event_technician_task";
            // string qry2 = "select time_format(appointed_time - used_time, '"+expression+"') from event_technician_task where task = '"+r+"'";

            testReportMethod(qry);
            getTimeDif();
        }

        private void testReportMethod(string qry)
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = null;

            table.Columns.Add("Staff_ID", typeof(int));
           // table.Columns.Add("task_id", typeof(int));
            table.Columns.Add("Task", typeof(string));
            table.Columns.Add("Appointed_time", typeof(TimeSpan));
            table.Columns.Add("Used_time", typeof(TimeSpan));
            //table.Columns.Add("Time_difference", typeof(TimeSpan));

            try
            {
                reader = DBConnection.getData(qry);


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader.GetInt32("event_tech_id"),reader.GetString("task"), reader.GetTimeSpan("appointed_time"), reader.GetTimeSpan("used_time"));
                    }

                    if (reader != null)
                        if (!reader.IsClosed)
                            reader.Close();

                    TaskDuration rpt = new TaskDuration();

                    rpt.Database.Tables["Task"].SetDataSource(table);

                    crystalReportViewer1.ReportSource = null;
                    crystalReportViewer1.ReportSource = rpt;
                }
                else
                {
                    if (reader != null)
                        if (!reader.IsClosed)
                            reader.Close();

                    MessageBox.Show("No records yet!", "Event task Reporting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exc)
            {
                if (reader != null)
                    if (!reader.IsClosed)
                        reader.Close();

                MessageBox.Show("No records yet!\n" + exc, "Event task Reporting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void fillselectStaffCmbBox()
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select * from event_technician_task ");

                selectStaffCmbBox.Items.Clear();

                while (reader.Read())
                {
                    selectStaffCmbBox.Items.Add(reader.GetString("event_tech_id"));
                }

                reader.Close();
            }

            catch (Exception ee)
            {
                MessageBox.Show("Something went wrong!\n" + ee, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectStaffCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tId = Int32.Parse(selectStaffCmbBox.SelectedItem.ToString());
            //fillselectStaffCmbBox();
        }

        private void selectStfNmeCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // sId = selectStfNmeCmbBox.SelectedItem.ToString();
        }

        private void StaffReportForm_Load(object sender, EventArgs e)
        {
            fillselectStaffCmbBox();
            //fillselectStfNmeCmbBox();
        }

        

        private void getTimeDif()
        {
            try
            {
                string expression = "%T";

                MySqlDataReader reader = DBConnection.getData("select time_format(appointed_time, '" + expression + "') as AppointedTime from event_technician_task where task = '" + tsk + "'");

                while (reader.Read())
                {
                    a = reader.GetString("AppointedTime").ToString();
                    at = Convert.ToDateTime(a.ToString());
                }

                reader.Close();

                reader = DBConnection.getData("select time_format(used_time, '" + expression + "') as UsedTime from event_technician_task where task = '" + tsk + "'");

                while (reader.Read())
                {
                    u = reader.GetString("UsedTime").ToString();
                    ut = Convert.ToDateTime(u.ToString());
                }
                
                reader.Close();

                if (at >= ut)
                {
                    dif = at - ut;
                }

                else
                {
                    dif = ut - at;
                }

                DataTable t = new DataTable();
                t.Columns.Add("Time_difference", typeof(TimeSpan));

            }

            catch (Exception exe)
            {
                MessageBox.Show("Something went wrong!\n" + exe, "report generating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*
            DataTable t = new DataTable();
            MySqlDataReader reader = null;

            t.Columns.Add("Time_difference", typeof(TimeSpan));

            try
            {
                reader = DBConnection.getData(qry2);


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        t.Rows.Add(reader.GetTimeSpan(0));
                    }

                    if (reader != null)
                        if (!reader.IsClosed)
                            reader.Close();

                    TaskDuration rpt = new TaskDuration();

                    rpt.Database.Tables["T"].SetDataSource(t);

                    crystalReportViewer1.ReportSource = null;
                    crystalReportViewer1.ReportSource = rpt;
                }
                else
                {
                    if (reader != null)
                        if (!reader.IsClosed)
                            reader.Close();

                    MessageBox.Show("No records yet!", "Event task Reporting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exc)
            {
                if (reader != null)
                    if (!reader.IsClosed)
                        reader.Close();

                MessageBox.Show("No records yet!\n" + exc, "Event task Reporting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
        }

        private void stfRep_click_Click(object sender, EventArgs e)
        {
            //string que = "select first_name,basic_salary,ot_rate from staff where first_name = '" + sId+"' ";
            string que = "select * from staff ;";

            reportmethd2(que);
        }



        private void reportmethd2(string que)
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = null;

            table.Columns.Add("First_Name", typeof(string));
            table.Columns.Add("Basic_salary", typeof(float));
            table.Columns.Add("OT_rate", typeof(float));
            table.Columns.Add("OT_amount", typeof(float));

            try
            {
                reader = DBConnection.getData(que);


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader.GetString("first_name"), reader.GetFloat("basic_salary"), reader.GetFloat("ot_rate"));
                    }

                    if (reader != null)
                        if (!reader.IsClosed)
                            reader.Close();

                    TaskEfficiency rpt = new TaskEfficiency();

                    rpt.Database.Tables["StaffSal"].SetDataSource(table);

                    crystalReportViewer1.ReportSource = null;
                    crystalReportViewer1.ReportSource = rpt;
                }
                else
                {
                    if (reader != null)
                        if (!reader.IsClosed)
                            reader.Close();

                    MessageBox.Show("No records yet!", "Event task Reporting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exc)
            {
                if (reader != null)
                    if (!reader.IsClosed)
                        reader.Close();

                MessageBox.Show("No records yet!\n" + exc, "Event task Reporting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fillselectStfNmeCmbBox()
        {
            /*
            try
            {
                MySqlDataReader reader = DBConnection.getData("select * from staff ");

                selectStfNmeCmbBox.Items.Clear();

                while (reader.Read())
                {
                    selectStfNmeCmbBox.Items.Add(reader.GetString("first_name"));
                }

                reader.Close();
            }

            catch (Exception ee)
            {
                MessageBox.Show("Something went wrong!\n" + ee, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
    }
}
