using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Common;
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
    public partial class StaffForm : MetroFramework.Forms.MetroForm
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Userglobals.uname == "")
            {
                profilebtn.Visible = false;
                staffAddBtn.Visible = false;
                staffClearBtn.Visible = false;

            }
            else
            {
                if (Userglobals.priv != "PM" || Userglobals.priv != "HR" || Userglobals.priv != "ADM")
                {
                    staffAddBtn.Visible = false;
                    staffClearBtn.Visible = false;
                    
                }

                profilebtn.Visible = true;
                profilebtn.Text = Userglobals.uname;


            }


            fillDesigCmbBox();
        }

        private void fillDesigCmbBox()
        {
            MySqlDataReader reader = DBConnection.getData("select * from designation");

            desgCmbBox.Items.Clear();

            while (reader.Read())
            {
                desgCmbBox.Items.Add(reader.GetString("designation_name"));
            }

            reader.Close();
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void htmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void htmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string firstName = fNameTxtBox.Text;
            string lastName = lNameTxtBox.Text;
            string Nic = addNICtxtBox.Text;
            string pAddress = pAddTxtBox.Text;
            string sAddress = sAddTxtBox.Text;
            string []telNumber = new string[2];
            telNumber[0] = telMobileTxtBox.Text;
            telNumber[1] = telLanTxtBox.Text;
            string email = emailTxtBox.Text;
            string facebook = fNameTxtBox.Text;
            string linkedIn = linkedTxtBox.Text;
            float basicSal = float.Parse(basicSalTxtBox.Text.ToString());
            float otRate = float.Parse(otRateTxtBox.Text.ToString());

            Designation desg = new Designation(desgCmbBox.SelectedItem.ToString());

            MySqlDataReader reader = DBConnection.getData("Select desig_id from Designation where designation_name='"+ desg.DesignationName +"'");

            if (reader.Read())
                desg.DesigId = reader.GetInt32("desig_id");

            Staff stf = new Staff(firstName, lastName, Nic, pAddress, sAddress, telNumber, email, facebook, linkedIn, basicSal, otRate);

            reader.Close();

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void closeForm()
        {
            this.Close();
        }

        void clear ()
        {
            fNameTxtBox.Clear();
            lNameTxtBox.Clear();
            addNICtxtBox.Clear();
            pAddTxtBox.Clear();
            sAddTxtBox.Clear();
            telMobileTxtBox.Clear();
            telLanTxtBox.Clear();
            emailTxtBox.Clear();
            fbTxtBox.Clear();
            linkedTxtBox.Clear();
            basicSalTxtBox.Clear();
            otRateTxtBox.Clear();
            desgCmbBox.SelectedItem = null;

            addNewDesTxtBox.Clear();
           // addDesIdTxtBox.Clear();
        }

      
        private void metroButton2_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                /* if (c is TextBox)
                 {
                     c.Text = "";
                 } */

                clear();
            }
        }

        private void staffClearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clearNewDesBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void addNewDesBtn_Click(object sender, EventArgs e)
        {
            string designation = addNewDesTxtBox.Text;
           // int desigId = Int32.Parse(addDesIdTxtBox.Text.ToString());

            Designation des = new Designation(designation);

            try
            {

                Database.addDesignation(des);

                MessageBox.Show("New designation added successfully.", "New designation Adding", MessageBoxButtons.OK);

                clear();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Detail must be added!\n" + ex, "New designation adding", MessageBoxButtons.OK);
            }
        }

        private void staffAddBtn_Click(object sender, EventArgs e)
        {
            /*
            string firstName = fNameTxtBox.Text;
            string lastName = lNameTxtBox.Text;
            string Nic = addNICtxtBox.Text;
            string pAddress = pAddTxtBox.Text;
            string sAddress = sAddTxtBox.Text;
            string[] telNumber = new string[2];
            telNumber[0] = telMobileTxtBox.Text;
            telNumber[1] = telLanTxtBox.Text;
            string email = emailTxtBox.Text;
            string facebook = fNameTxtBox.Text;
            string linkedIn = linkedTxtBox.Text;
            float basicSal = float.Parse(basicSalTxtBox.Text.ToString());
            float otRate = float.Parse(otRateTxtBox.Text.ToString());

            Designation desg = new Designation(desgCmbBox.SelectedItem.ToString());

            MySqlDataReader reader = DBConnection.getData("Select desig_id from Designation where designation='" + desg.DesignationName + "'");

            if (reader.Read())
                desg.DesigId = reader.GetInt32("desig_id");

            Staff stf = new Staff(firstName, lastName, Nic, pAddress, sAddress, telNumber, email, facebook, linkedIn, basicSal, otRate);

            reader.Close();

            Database.addStaff(stf);
            */

            string firstName = fNameTxtBox.Text;
            string lastName = lNameTxtBox.Text;
            string Nic = addNICtxtBox.Text;
            string pAddress = pAddTxtBox.Text;
            string sAddress = sAddTxtBox.Text;
            string[] telNumber = new string[2];
            telNumber[0] = telMobileTxtBox.Text;
            telNumber[1] = telLanTxtBox.Text;
            string email = emailTxtBox.Text;
            string facebook = fNameTxtBox.Text;
            string linkedIn = linkedTxtBox.Text;
            float basicSal = float.Parse(basicSalTxtBox.Text.ToString());
            float otRate = float.Parse(otRateTxtBox.Text.ToString());

            Designation desg = new Designation(desgCmbBox.SelectedItem.ToString());

            Staff stf = new Staff(firstName, lastName, Nic, pAddress, sAddress, telNumber, email, facebook, linkedIn, basicSal, otRate);
            int stfid = 0; 

            try
            {
                MySqlDataReader reader = DBConnection.getData("Select desig_id from Designation where designation_name='" + desg.DesignationName + "'");

                while (reader.Read())
                {
                    desg.DesigId = reader.GetInt32("desig_id");
                }

                reader.Close();

                stf.Designation = desg;

                Database.addStaff(stf);

                MessageBox.Show("New member added successfully.", "New member Adding", MessageBoxButtons.OK);

                reader = DBConnection.getData("Select staff_id from staff where nic='" + Nic + "'");

                while (reader.Read())
                { 
                    stfid = int.Parse(reader["staff_id"].ToString());
                }
                reader.Close();

                UserOperation operation = new UserOperation(new Role.UserLog(Logglobals.id), "Added a new Staff member", stfid);

                try{
                    Database.addOp(operation);
                }
                catch(Exception)
                {

                }

                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Every detail must be added!\n" + ex, "New member Adding", MessageBoxButtons.OK);
            }

            // metroGrid1.DataSource = getUserList();

            //MemberListForm mem = new MemberListForm();
            //mem.Show();

            //closeForm();


        }

        private void AddMemberTab_Click(object sender, EventArgs e)
        {

        }

        private void desgCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addDesIdTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void addNewDesTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void fNameTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void addNICtxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";

            if (!Validation.isValidNic(addNICtxtBox.Text, out errorMsg))
            {
                e.Cancel = true;

                addNICtxtBox.Select(0, addNICtxtBox.Text.Length);

                this.errorProviderAddStaff.SetError(addNICtxtBox, errorMsg);
            }
        }

        private void addNICtxtBox_Validated(object sender, EventArgs e)
        {
            errorProviderAddStaff.SetError(addNICtxtBox, "");
            errorProviderAddStaff.Clear();
        }

        private void addNICtxtBox_Click(object sender, EventArgs e)
        {

        }

        private void telMobileTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isValidPhoneNumber(telMobileTxtBox.Text, out errorMsg))
            {
                e.Cancel = true;

                telMobileTxtBox.Select(0, telMobileTxtBox.Text.Length);

                this.errorProviderAddStaff.SetError(telMobileTxtBox, errorMsg);
            }
        }

        private void telMobileTxtBox_Validated(object sender, EventArgs e)
        {
            errorProviderAddStaff.SetError(telMobileTxtBox, "");
            errorProviderAddStaff.Clear();
        }

        private void telLanTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isValidPhoneNumber(telLanTxtBox.Text, out errorMsg))
            {
                e.Cancel = true;

                telLanTxtBox.Select(0, telLanTxtBox.Text.Length);

                this.errorProviderAddStaff.SetError(telLanTxtBox, errorMsg);
            }
        }

        private void telLanTxtBox_Validated(object sender, EventArgs e)
        {
            errorProviderAddStaff.SetError(telLanTxtBox, "");
            errorProviderAddStaff.Clear();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void htmlLabel16_Click(object sender, EventArgs e)
        {

        }
        
        private void demo_stf_btn_Click(object sender, EventArgs e)
        {
            fNameTxtBox.Text = "Sajith";
            lNameTxtBox.Text = "Perera";
            addNICtxtBox.Text = "882232576v";
            pAddTxtBox.Text = "No.15, Peradeniya Road, Kandy.";
            sAddTxtBox.Text = "No.23/2, Third Lane, Malabe.";
            telMobileTxtBox.Text = "0712455455";
            telLanTxtBox.Text = "0812225073";
            emailTxtBox.Text = "sajithperera@gmail.com";
            fbTxtBox.Text = "Sajith Perera";
            linkedTxtBox.Text = "SP Perera";
            basicSalTxtBox.Text = "50000";
            otRateTxtBox.Text = "50";
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
