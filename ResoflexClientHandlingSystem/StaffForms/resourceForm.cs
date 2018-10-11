using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
using ResoflexClientHandlingSystem.UserForms;
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
    public partial class resourceForm : MetroFramework.Forms.MetroForm
    {
        int Id;
        int availableQty;
        bool update = false;

        public resourceForm()
        {
            InitializeComponent();
        }

        public void setUpdateDetails(int Id, string name, float value, int totalQty, int availableQty)
        {
            this.Id = Id;
            nameResTxtBox.Text = name;
            valueResTxtBox.Text = value.ToString();
            qtyResTxtBox.Text = totalQty.ToString();
            this.availableQty = availableQty;
        }

        private void resourceForm_Load(object sender, EventArgs e)
        {
            if (Userglobals.uname == "")
            {
                profilebtn.Visible = false;
                resAddBtn.Visible = false;
                DelResBtn.Visible = false;
                UpdateResBtn.Visible = false;

            }
            else
            {
                if (Userglobals.priv != "PM" || Userglobals.priv != "HR" || Userglobals.priv != "ADM")
                {
                    resAddBtn.Visible = false;
                    DelResBtn.Visible = false;
                    UpdateResBtn.Visible = false;

                }

                profilebtn.Visible = true;
                profilebtn.Text = Userglobals.uname;


            }

            loadResourceToGrid();

            ResGrid.Columns[0].Visible = false;

        }

        void clear()
        {
            nameResTxtBox.Clear();
            valueResTxtBox.Clear();
            qtyResTxtBox.Clear();
        }

        private void resClearBtn_Click(object sender, EventArgs e)
        {
            update = false;
            resAddBtn.Text = "Add";
            clear();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            int resID = Int32.Parse(ResGrid.CurrentRow.Cells[0].Value.ToString());
            string nm = ResGrid.CurrentRow.Cells[1].Value.ToString();
            float val = float.Parse(ResGrid.CurrentRow.Cells[2].Value.ToString());
            int totQty = Int32.Parse(ResGrid.CurrentRow.Cells[3].Value.ToString());
            int avaQty = Int32.Parse(ResGrid.CurrentRow.Cells[4].Value.ToString());
            update = true;

            resAddBtn.Text = "Update";

            setUpdateDetails(resID, nm, val, totQty, avaQty);
            
            //update resource by clicking update button
        }

        private void resAddBtn_Click(object sender, EventArgs e)
        {
            string name = nameResTxtBox.Text;
            float value = float.Parse(valueResTxtBox.Text);
            int totalQty = Int32.Parse(qtyResTxtBox.Text);
            int availableQty = Int32.Parse(qtyResTxtBox.Text);
            
            try
            {
                if (update)
                {
                    update = false;
                    resAddBtn.Text = "Add";

                    Resource reso2 = new Resource(Id, name, value, totalQty, availableQty);
                    Core.Database.updateResource(reso2);
                }
                else
                {
                    Resource reso = new Resource(name, value, totalQty, availableQty);
                    Core.Database.addResource(reso);
                }
                
                loadResourceToGrid();
                
                try
                {
                    clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Every detail must be added!", "New resource adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("New resource added successfully.", "New resource Adding", MessageBoxButtons.OK);

            // metroGrid1.DataSource = getUserList();

        }


        public void loadResourceToGrid()
        {
            MySqlDataReader reader = DBConnection.getData("select resource_id, name as Name, value as Value, total_qty as Total_Quantity, available_qty from resource");

            DataTable table = new DataTable();

            table.Load(reader);

            ResGrid.DataSource = table;
        }

        private void resourceForm_Shown(object sender, EventArgs e)
        {
          //  loadResourceToGrid();

          //  ResGrid.Columns[0].Visible = false;
        }

        private void DelResBtn_Click(object sender, EventArgs e)
        {
            // int rowIndex = ResGrid.CurrentCell.RowIndex;
            // ResGrid.Rows.RemoveAt(rowIndex);

            DataGridViewRow dr = ResGrid.CurrentRow;

            Resource resource = new Resource();
            resource.ResourceId = int.Parse(dr.Cells[0].Value.ToString());

            if (Database.deleteResource(resource))
            {
                MessageBox.Show("Schedule Successfully Deleted\n", "Resource Deleted", MessageBoxButtons.OK);

                loadResourceToGrid();
            }
            else
            {
                MessageBox.Show("Something went wrong!\n", "Resource Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private DataTable searchFromResource()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = DBConnection.getData("SELECT * FROM resource WHERE name LIKE '%"
                + selectResourceTxtbox.Text + "%'");
            table.Load(reader);
            return table;

        }

        private void selectResourceTxtbox_TextChanged(object sender, EventArgs e)
        {
            ResGrid.DataSource = searchFromResource();
        }
        
        private void demo_res_btn_Click(object sender, EventArgs e)
        {
            nameResTxtBox.Text = "Portable DVD drivers";
            valueResTxtBox.Text = "10";
            qtyResTxtBox.Text = "10000";
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
