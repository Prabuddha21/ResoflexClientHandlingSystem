﻿using MySql.Data.MySqlClient;
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

namespace ResoflexClientHandlingSystem
{
    public partial class EventDetailsForm : MetroFramework.Forms.MetroForm
    {
        public EventDetailsForm()
        {
            InitializeComponent();
        }

        private void EventDetailsForm_Load(object sender, EventArgs e)
        {
            fillCmbBoxes();
        }

        private void fillCmbBoxes()
        {
            DataTable tableProject = new DataTable();

            // Project cmb box
            MySqlDataReader readerProject = DBConnection.getData("select proj_id, proj_name from project");
            
            tableProject.Load(readerProject);

            byProjectCmbBox.DataSource = tableProject;
            byProjectCmbBox.ValueMember = "proj_id";
            byProjectCmbBox.DisplayMember = "proj_name";

            MySqlDataReader readerClient = DBConnection.getData("select client_id, name from client");

            DataTable tableClient = new DataTable();

            tableClient.Load(readerClient);

            byClientCmbBox.DataSource = tableClient;
            byClientCmbBox.ValueMember = "client_id";
            byClientCmbBox.DisplayMember = "name";

            MySqlDataReader readerExpType = DBConnection.getData("select exp_type_id, type from expense_type");

            DataTable tableExpType = new DataTable();

            tableExpType.Load(readerExpType);

            byExpTypeCmbBox.DataSource = tableExpType;
            byExpTypeCmbBox.ValueMember = "exp_type_id";
            byExpTypeCmbBox.DisplayMember = "type";
        }

        private void EventDetailsForm_Shown(object sender, EventArgs e)
        {
            eventExpGrid.DataSource = getEventExp();

            eventExpGrid.Columns[0].Visible = false;
            eventExpGrid.Columns[1].Visible = false;
            eventExpGrid.Columns[2].Visible = false;

            if (eventExpGrid.Rows.Count >= 1)
            {
                int projId = Int32.Parse(eventExpGrid.Rows[0].Cells[0].Value.ToString());
                int eventId = Int32.Parse(eventExpGrid.Rows[0].Cells[2].Value.ToString());

                fillExpTypeTiles(projId, eventId);
                fillBriefDetailTiles(projId, eventId);
            }
        }

        private void fillBriefDetailTiles(int projId, int eventId)
        {
            maxExpProjTile.Text = "Rs.0.00";
            totalExpProjTile.Text = "Rs.0.00";
            noTechTile.Text = "0";

            MySqlDataReader reader = DBConnection.getData("select MAX(amount) as max, SUM(amount) as sum from exp_detail_event where " +
                                                          "proj_id=" + projId + " group by proj_id;");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    maxExpProjTile.Text = "Rs." + reader.GetDouble(0);
                    totalExpProjTile.Text = "Rs." + reader.GetDouble(1);
                }
            }
            else
            {
                maxExpProjTile.Text = "Rs.0.00";
                totalExpProjTile.Text = "Rs.0.00";
            }

            reader.Close();

            reader = DBConnection.getData("SELECT IFNULL(COUNT(staff_id), 0) as no FROM event_technicians WHERE proj_id=" + projId + " AND event_id=" + eventId + " GROUP BY " +
                "proj_id, event_id;");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    noTechTile.Text = "" + reader.GetInt16(0);
                }
            }
            else
            {
                noTechTile.Text = "0";
            }

            reader.Close();
        }

        private DataTable getEventExp()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = null;

            try
            {
                reader = DBConnection.getData("SELECT v.proj_id, c.client_id, v.event_id, p.proj_name as Project, c.name as Client, v.from_date_time as From_Date, " +
                    "v.to_date_time as To_Date, v.travelling_mode as Travel, v.accommodation_mode as Accom, v.meals as Meals, IFNULL(SUM(e.amount), 0) as Expense " +
                    "FROM project p RIGHT JOIN event v ON p.proj_id=v.proj_id LEFT JOIN client c ON c.client_id=p.client_id LEFT JOIN exp_detail_event e ON " +
                    "e.event_id=v.event_id AND e.proj_id=v.proj_id GROUP BY v.proj_id, v.event_id;");

                table.Load(reader);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!\n" + exc, "Event Expenses getter", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (reader != null)
                    if (!reader.IsClosed)
                        reader.Close();
            }

            return table;
        }

        private void fillExpTypeTiles(int projId, int eventId)
        {
            mealExpTile.Text = "Rs.0.00";
            accTile.Text = "Rs.0.00";
            travelExpTile.Text = "Rs.0.00";
            otherExpTile.Text = "Rs.0.00";

            double other = 0.0;

            MySqlDataReader reader = DBConnection.getData("SELECT t.type as type, IFNULL(SUM(e.amount), 0) amount FROM expense_type t LEFT JOIN " +
                "exp_detail_event e ON e.exp_type_id=t.exp_type_id WHERE e.event_id=" + eventId + " AND e.proj_id=" + projId + " GROUP BY e.exp_type_id;");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetString(0).Equals("Meals"))
                        mealExpTile.Text = "Rs." + reader.GetDouble(1);
                    else if (reader.GetString(0).Equals("Accommodation"))
                        accTile.Text = "Rs." + reader.GetDouble(1);
                    else if (reader.GetString(0).Equals("Travel"))
                        travelExpTile.Text = "Rs." + reader.GetDouble(1);
                    else
                        other += reader.GetDouble(1);
                }

                otherExpTile.Text = "Rs." + other;
            }
            else
            {
                mealExpTile.Text = "Rs.0.00";
                accTile.Text = "Rs.0.00";
                travelExpTile.Text = "Rs.0.00";
                otherExpTile.Text = "Rs.0.00";
            }

            reader.Close();
        }
        
        private void eventExpGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            
            if (dgv.CurrentRow.Selected)
            {
                int projId = Int32.Parse(eventExpGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                int eventId = Int32.Parse(eventExpGrid.Rows[e.RowIndex].Cells[2].Value.ToString());

                fillExpTypeTiles(projId, eventId);
                fillBriefDetailTiles(projId, eventId);
            }
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            eventExpGrid.DataSource = getEventExp();

            if (eventExpGrid.Rows.Count >= 1)
            {
                int projId = Int32.Parse(eventExpGrid.Rows[0].Cells[0].Value.ToString());
                int eventId = Int32.Parse(eventExpGrid.Rows[0].Cells[2].Value.ToString());

                fillExpTypeTiles(projId, eventId);
                fillBriefDetailTiles(projId, eventId);
            }
        }
    }
}
