using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.UserForms
{
    public partial class ProfileForm : MetroFramework.Forms.MetroForm
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Logglobals.logout = DateTime.Now;

            Role.UserLog log = new Role.UserLog(Logglobals.id, Logglobals.logout.ToString("yyyy-MM-dd HH:mm:ss"), Logglobals.detail);

            try
            {
                Database.updateLog(log);

                Userglobals.uid = 0;
                Userglobals.uname = "";
                Userglobals.priv = "";

                Logglobals.detail = "";
                Logglobals.ip = "";
                Logglobals.login.ToLocalTime();
                Logglobals.logout.ToLocalTime();
                Logglobals.id = 0;

                Dashboard dash = new Dashboard();
                this.Hide();
                dash.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            if (Userglobals.uname == "")
            {
                metroButton1.Visible = false;
                metroButton2.Visible = false;
            }
            else
            {

                try
                {
                    MySqlDataReader reader = DBConnection.getData("SELECT s.first_name, s.last_name, u.u_name FROM staff s, user u where user_id='" + Userglobals.uid.ToString() + "' and s.staff_id = u.user_id;");

                    while (reader.Read())
                    {
                        metroLabel1.Text = (reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString());
                        txtUname.Text = reader.GetValue(2).ToString();

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }


            }
        }    

        public void onClick()
        {
            if (string.IsNullOrWhiteSpace(txtCurPass.Text))
            {

                MessageBox.Show("Enter the current password to update credentials");
            }
            else if (txtUname.Text.ToString().Equals(Userglobals.uname.ToString()) && (string.IsNullOrWhiteSpace(txtPass.Text)))
            {
                MessageBox.Show("Enter a different username to update");

            }
            else if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MySqlDataReader reader = DBConnection.getData("select password from user where user_id = '" + Userglobals.uid + "';");
                String curPass;

                if (reader.Read())
                {
                    curPass = reader.GetValue(0).ToString();

                    reader.Close();

                    User user = new User(int.Parse(Userglobals.uid.ToString()), txtUname.Text.ToString(), curPass);

                    try
                    {
                        Database.updateUser(user);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Every detail must be added!", "Updating Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("Profile updated successfully", "Updating Profile", MessageBoxButtons.OK);

                    this.Refresh();
                }
                else
                {
                    reader.Close();
                }
            }
            else
            {
                MySqlDataReader reader = DBConnection.getData("select password from user where user_id = '" + Userglobals.uid + "';");
                String curPass;

                if (reader.Read())
                {
                    curPass = reader.GetValue(0).ToString();

                    if ((Eramake.eCryptography.Encrypt(txtPass.Text).ToString().Equals(curPass)))
                    {

                        reader.Close();
                        MessageBox.Show("Your new password has to be different to the previous one");
                    }
                    else
                    {
                        reader.Close();

                        User user = new User(int.Parse(Userglobals.uid.ToString()), txtUname.Text.ToString(), Eramake.eCryptography.Encrypt(txtCurPass.Text).ToString());

                        try
                        {
                            Database.updateUser(user);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Every detail must be added!", "Updating Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MessageBox.Show("Profile updated successfully", "Updating Profile", MessageBoxButtons.OK);

                        this.Refresh();
                        Refresh();
                    }
                }
                reader.Close();


            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            onClick();
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {

        }

        private void schHome_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            this.Hide();
            dsh.ShowDialog();
            this.Close();
        }
    }
}
