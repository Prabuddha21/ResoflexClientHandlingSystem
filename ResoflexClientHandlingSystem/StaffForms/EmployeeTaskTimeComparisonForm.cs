using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
﻿using ResoflexClientHandlingSystem.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.StaffForms
{
    public partial class EmployeeTaskTimeComparisonForm : MetroFramework.Forms.MetroForm
    {

        int tId;
        string tsk;
        public EmployeeTaskTimeComparisonForm()
        {
            InitializeComponent();
        }

        private void selectTaskCmbBox_SelectedValueChanged(object sender, EventArgs e)
        {
            /////////////////
        }

        private void EmployeeTaskTimeComparisonForm_Load(object sender, EventArgs e)
        {
            fillselectMemCmbBox();
            fillselectTaskCmbBox();
        }

        private void fillselectMemCmbBox()
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select * from event_technician_task ");

                selectMemCmbBox.Items.Clear();

                while (reader.Read())
                {
                    selectMemCmbBox.Items.Add(reader.GetString("event_tech_id"));
                }

                reader.Close();
            }

            catch (Exception ee)
            {
                MessageBox.Show("Something went wrong!\n" +ee, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            try
            {
                tId = Int32.Parse(selectMemCmbBox.SelectedItem.ToString());
                fillselectTaskCmbBox();
            }

            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong!\n" + exc, "Selecting Staff ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void fillselectTaskCmbBox()
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select task from event_technician_task where event_tech_id = " +tId+ "");
               // MySqlDataReader reader = DBConnection.getData("select * from event_technician_task");

                selectTaskCmbBox.Items.Clear();

                while (reader.Read())
                {
                    selectTaskCmbBox.Items.Add(reader.GetString("task"));
                }

                reader.Close();
            }

            catch
            {
                MessageBox.Show("Something went wrong!\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillTimeTiles()
        {
            try
            {
                string expression = "%T";

                MySqlDataReader reader = DBConnection.getData("select time_format(appointed_time, '"+expression+"') as AppointedTime from event_technician_task where task = '" + tsk + "'");

                while (reader.Read())
                {
                    timeAtile.Text = reader.GetString("AppointedTime").ToString();
                }

                reader.Close();

                reader = DBConnection.getData("select time_format(used_time, '" + expression + "') as UsedTime from event_technician_task where task = '" + tsk + "'");

                while (reader.Read())
                {
                    timeUtile.Text = reader.GetString("UsedTime").ToString();
                }

                reader.Close();
            }

            catch (Exception exe)
            {
                MessageBox.Show("Something went wrong!\n" +exe, "Selecting a task", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void selectTaskCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsk = selectTaskCmbBox.Text.ToString();
            fillTimeTiles();
        }

        private void filltimeDiffTile()
        {
            DateTime appoint = Convert.ToDateTime(timeAtile.Text.ToString());
            DateTime used = Convert.ToDateTime(timeUtile.Text.ToString());

            //TimeSpan diff = appoint - used;
            TimeSpan diff;
           
            try
            {
                if (appoint >= used)
                {
                    diff = appoint - used;
                }

                else
                {
                    diff = used - appoint;
                }

                timeDiffTile.Text = diff.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!\n" + ex, "Comparing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            try
            {
              // float app = float.Parse(timeAtile.ToString());
              // float usd = float.Parse(timeUtile.ToString());



                this.timeChart.Series["Time"].Points.Clear();

                //string app1 = timeAtile.Text.ToString();
                //string app2 = timeUtile.Text.ToString();

               DateTime app1 = Convert.ToDateTime(timeAtile.Text.ToString());
               DateTime app2 = Convert.ToDateTime(timeUtile.Text.ToString());

                this.timeChart.Series["Time"].Points.AddXY("Appointed", app1.ToString("HH.mm"));
                this.timeChart.Series["Time"].Points.AddXY("Used", app2.ToString("HH.mm"));
            }

            catch (Exception ec)
            {
                MessageBox.Show("Something went wrong!\n" + ec, "Comparing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            filltimeDiffTile();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }
        
        private void reportsBtn_Click(object sender, EventArgs e)
        {
            StaffReports.StaffReportForm viewRepo = new StaffReports.StaffReportForm();
            this.Hide();
            viewRepo.ShowDialog();
        }
        
        private void profilebtn_Click(object sender, EventArgs e)
        {
            ProfileForm prffrm = new ProfileForm();
            this.Hide();
            prffrm.ShowDialog();
            this.Close();
        }
    }
}
