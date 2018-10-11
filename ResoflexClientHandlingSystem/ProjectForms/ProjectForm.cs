using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.RequestForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResoflexClientHandlingSystem.Properties;
using ResoflexClientHandlingSystem.Role;

namespace ResoflexClientHandlingSystem
{
    public partial class ProjectForm : MetroFramework.Forms.MetroForm
    {
        string clientName = "";

        public ProjectForm()
        {
            InitializeComponent();
        }

        public ProjectForm(string clientName)
        {
            InitializeComponent();

            this.clientName = clientName;
        }

        private void Project1_Load(object sender, EventArgs e)
        {
            if (Userglobals.uname == "")
            {
                profilebtn.Visible = false;
                addProjectBtn.Visible = false;
                updateProjectBtn.Visible = false;
                metroButton1.Visible = false;

            }
            else
            {
                if (Userglobals.priv == "PM" || Userglobals.priv == "ADM")
                {
                    addProjectBtn.Visible = true;
                    updateProjectBtn.Visible = true;
                    metroButton1.Visible = true;
                }
                else
                {
                    addProjectBtn.Visible = true;
                    updateProjectBtn.Visible = true;
                    metroButton1.Visible = true;
                }

                profilebtn.Visible = true;
                profilebtn.Text = Userglobals.uname;


            }
            projectGrid.DataSource = getProjects();
            projIdTile.BackColor = Color.DeepSkyBlue;
            fillCountTile();
            totExpenceTile.BackColor = Color.DeepSkyBlue;
            warrantyTile.BackColor = Color.DeepSkyBlue;

            try
            {
                MySqlDataReader reader = DBConnection.getData("select statues from notification where user_id="+Userglobals.uid+"");

                while (reader.Read())
                {
                    metroTextBox1.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }


            if (clientName != "")
                searchProjectTxtBox.Text = clientName;

            projectGrid.Columns[0].Visible = true;


            if (Userglobals.uname == "")
            {
                addProjectBtn.Visible = false;
                updateProjectBtn.Visible = false;
                
            }
            else
            {
                if (!Userglobals.priv.ToLower().Equals("adm") && !Userglobals.priv.ToLower().Equals("admin"))
                {
                    addProjectBtn.Visible = false;
                    updateProjectBtn.Visible = false;
                }

                profilebtn.Visible = true;
                profilebtn.Text = Userglobals.uname;
            }


        }


        //tile

        private void fillCountTile()
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select count(proj_id) from project ");

                while (reader.Read())
                {
                    projIdTile.Text = (reader.GetValue(0).ToString());
                }

                reader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }


            }

        private void fillTiles(int projectID)
        {
            try
            {
                 
                MySqlDataReader reader = DBConnection.getData("select DATE_FORMAT(warranty_start_date, '%y-%m-%d') from project where proj_id = " + projectID);

                while (reader.Read())
                {
                    totExpenceTile.Text = (reader.GetValue(0).ToString());
                }

                reader.Close();

                reader = DBConnection.getData("select count(proj_id) from proj_request where proj_id=" + projectID);

                while (reader.Read())
                {
                    warrantyTile.Text = (reader.GetValue(0).ToString());
                }

                reader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            } 

          
        }

        private void projectGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.CurrentRow.Selected)
            {
                int projectID = Int32.Parse(projectGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                fillTiles(projectID);
            }
        }

        //

        private DataTable getProjects()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select p.proj_id, p.proj_name as Project_Name,p.description as Description, c.name as Client_Name from project p, client c where p.client_id=c.client_id group by p.proj_id desc");

            table.Load(reader);

            return table;
        }

        private void projectGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < projectGrid.Rows.Count; i++)
            {
                int val = Int32.Parse(projectGrid.Rows[i].Cells[3].Value.ToString());
                if (val >= 7000)
                {
                    projectGrid.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                }

            }
        }




        private void projectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.CurrentRow.Selected)
            {
                int projectID = Int32.Parse(projectGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                fillTiles(projectID);
            }
        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            UpdateProjectForm upPrj = new UpdateProjectForm();

            upPrj.Show();
        }

        private void updateProjectBtn_Click(object sender, EventArgs e)
        {
            ProjectUpdate prjUp = new ProjectUpdate();

            prjUp.Show();


        }

     






        private void addProjectBtn_Click_1(object sender, EventArgs e)
        {
            UpdateProjectForm frm = new UpdateProjectForm();

            frm.ShowDialog();

            projectGrid.DataSource = getProjects();
        }

        private void progressBtn_Click(object sender, EventArgs e)
        {
            ProjectRanks frm = new ProjectRanks();

            frm.ShowDialog();

            projectGrid.DataSource = getProjects();
        }

        private void updateProjectBtn_Click_1(object sender, EventArgs e)
        {
            ProjectUpdate frm = new ProjectUpdate();
            frm.ShowDialog();
            projectGrid.DataSource = getProjects();
        }

        //search
        private void searchProjectTxtBox_TextChanged(object sender, EventArgs e)
        {

            string qry = "";
            string projectNameTxt = searchProjectTxtBox.Text;
       

            qry = "SELECT p.proj_id as ID, " +
                "p.proj_name, " +
                "p.description, " +
                "p.proj_sub_cat_id, " +
                "p.first_init_date, " +
                "p.training_comp_first_end_date, " +
                "p.training_comp_second_end_date, " +
                "p.warranty_start_date, " +
                "p.warranty_terms, " +
                "p.support_terms, " +
                "p.visit_terms " +
                "from project p inner join client c on c.client_id=p.client_id where p.proj_name like '%" + projectNameTxt + "%' or c.name like '%" + projectNameTxt+ "%'";

            try
            {
                MySqlDataReader reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    System.Data.DataTable table1 = new System.Data.DataTable();

                    table1.Load(reader);

                    projectGrid.DataSource = table1;
                    reader.Close();
                }
                else
                {
                    reader.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Invalid data!\n" + exc.StackTrace, "Project finder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchProjectTxtBox.Text = "";

            projectGrid.DataSource = getProjects();
        }

        private void projIdTile_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            AddCatagory frm = new AddCatagory();
            frm.ShowDialog();
           
        }

      

        private void projectGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            int proid = Int32.Parse(projectGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

            ProjectForms.ProjectProgress frm = new ProjectForms.ProjectProgress(proid);
            frm.ShowDialog();
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            ProjectForms.ProjectProgress frm = new ProjectForms.ProjectProgress();
            frm.ShowDialog();
        }

        private void maintenanceBtn_Click(object sender, EventArgs e)
        {
            ProjectForms.Maintenance frm = new ProjectForms.Maintenance();
            frm.ShowDialog();
        }


        private void closeForm()
        {
            this.closeForm();
        }

        private void schHome_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void reqBtn_Click(object sender, EventArgs e)
        {
            string projectName = projectGrid.CurrentRow.Cells[1].Value.ToString();

            RequestForm frm = new RequestForm(projectName);

            frm.Show();

            //MySqlDataReader reader = DBConnection.getData("select  statues from notification where user_id="+Userglobals.uid+"");

            //if (reader.Read())
            //{
            //      bool per = reader.GetBoolean(0);
            //      ProjectForms.GetPermission frm = new ProjectForms.GetPermission();
            //      frm.ShowDialog();
              // }
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           /* metroTextBox1.Text = Convert.ToString(metroTrackBar1.Value);
            int color = Convert.ToInt32(metroTextBox1.Text);

            projectGrid.BackgroundColor = Color.FromArgb(color);*/
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ProjectForms.Reports rpt = new ProjectForms.Reports();
            rpt.Show();
        }





        //
    }
}

