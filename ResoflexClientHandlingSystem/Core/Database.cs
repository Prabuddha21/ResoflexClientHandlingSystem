using MySql.Data.MySqlClient;
using System;
using ResoflexClientHandlingSystem.Role;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ResoflexClientHandlingSystem.Core
{
    class Database
    {
        public static void saveClient(Client client)
        {
            try
            {
                DBConnection.updateDB("insert into client (name, address, phone_mobile, phone_office, fax, email)" +
                                      " values ('" + client.FirstName + "" + client.LastName + "', '" + client.Address + "', " +
                                      "'" + client.PhoneNo[0] + "', '" + client.PhoneNo[1] + "', '" + client.Fax + "', " +
                                      "'" + client.Email + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Add client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addUsers(User user)
        {
            try
            {
                DBConnection.updateDB("insert into user (user_id, u_name, password, permission) values (" + user.StaffId + ",'" + user.UName + "','" + user.Pword + "','" + user.Permission + "')");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }


        public static void addLog(Role.UserLog log)
        {
            try
            {
                DBConnection.updateDB("insert into user_log (user_id, logged_in_dateTime, detail, ip) values " +
                    "(" + log.User.UserId + ",'" + log.LoggedInDateTime + "','" + log.Detail + "', '" + log.Ip + "')");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong!", "Logging in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addOp(Role.UserOperation operation)
        {
            try
            {
                DBConnection.updateDB("insert into user_operations (log_id, operation, id) values " +
                    "(" + operation.LogId.LogId + ",'" + operation.Operation + "','" + operation.Id + "')");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong!", "Adding user operations", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateLog(Role.UserLog log)
        {
            try
            {
                DBConnection.updateDB("update user_log set logged_out_dateTime='" + log.LoggedOutDateTime + "', detail='" + log.Detail + "' where log_id = '" + log.LogId + "';");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong!", "Logging out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateClient(Client client)
        {
            try
            {
                DBConnection.updateDB("update client set name='" + client.FirstName + "" + client.LastName + "', " +
                                      "address='" + client.Address + "', phone_mobile='" + client.PhoneNo[0] + "', " +
                                      "phone_office='" + client.PhoneNo[1] + "', fax='" + client.Fax + "', email='" + client.Email + "' " +
                                      "where client_id=" + client.ClientID);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateUser(User user)
        {
            try
            {
                DBConnection.updateDB("update user set u_name='" + user.UName + "', password='" +
                    user.Pword + "' where user_id = " + user.UserId + ";");
            }
            catch (Exception)
            {
                MessageBox.Show("", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateUserPassPerm(User user)
        {
            try
            {
                DBConnection.updateDB("update user set password='" +
                    user.Pword + "', permission='" + user.Permission + "' where user_id = " + user.UserId + ";");

                DBConnection.updateDB("update staff set desig_id=(SELECT desig_id from designation where designation_name ='" + user.Permission + "') where staff_id='" + user.UserId + "';");
            }
            catch (Exception)
            {
                MessageBox.Show("User Password can not be updated", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateUserPerm(User user)
        {
            try
            {
                DBConnection.updateDB("update user set permission'" + user.Permission + "' where user_id = " + user.UserId + ";");

                DBConnection.updateDB("update staff set desig_id=(SELECT desig_id from designation where designation_name ='" + user.Permission + "') where staff_id='" + user.UserId + "';");
            }
            catch (Exception)
            {
                MessageBox.Show("User Permission can not be updated", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void deleteUser(User user)
        {
            try
            {
                DBConnection.updateDB("update user set permission='NA' where user_id = " + user.UserId + ";");
                DBConnection.updateDB("update staff set desig_id = (select desig_id from designation where designation_name = 'NA')" +
                    "where staff_id ='" + user.UserId + "';");

            }
            catch (Exception)
            {
                MessageBox.Show("", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //added new queries bellow for schedule !!
        //
        //--------------------------------------

        public static void addProject(ResoflexClientHandlingSystem.Role.Project project)
        {
            Client client = project.ClientOfProject;

            try
            {
                DBConnection.updateDB("insert into project (client_id, proj_name, proj_sub_cat_id, proj_cat_id , description, warranty_terms, visit_terms, support_terms)"
                                        + " values (" + client.ClientID
                                        + ",'" + project.ProjectName
                                        + "'," + project.ProjectSubID
                                        + "," + project.ProjectCatID
                                        + ",'" + project.Projectdesc
                                        + "','" + project.WarrantyTerms
                                        + "','" + project.VisitTerms
                                        + "','" + project.SupportTerms + "')");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc, "Project NOT added", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void addProjectCat(ResoflexClientHandlingSystem.Role.ProjectCategory projectCat)
        {


            try
            {
                DBConnection.updateDB("insert into proj_category (cat_name) values ('" + projectCat.CategoryName + "')");

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc, "Project NOT added", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void updateProject(ResoflexClientHandlingSystem.Role.Project project)
        {
            try
            {
                DBConnection.updateDB("UPDATE project SET first_init_date ='" + project.FirstInitDate.ToString("yyyy/MM/d") + "', training_comp_first_end_date='" + project.TEndDate1.ToString("yyyy/MM/d") + "', training_comp_second_end_date='" + project.TEndDate2.ToString("yyyy/MM/dd") + "', warranty_start_date='" + project.WarrantyStart.ToString("yyyy/MM/dd") + "', warranty_period='" + project.WarrantyPeriod + "' WHERE proj_name='" + project.ProjectName + "';");


            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc, "Project NOT added", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addRecord(Attendance atten)
        {
            MySqlDataReader reader1021 = DBConnection.getData("select * from attendanceview where DATE(InTime) = '" + atten.InTime + "%' and StaffID = '" + atten.EmployeeNo + "'");

            if (reader1021.HasRows == false)
            {
                reader1021.Close();
                //  try
                // {
                DBConnection.updateDB("insert into attendance(staff_id, in_time, out_time, total_hours)values('" + atten.EmployeeNo + "','" + atten.InTime + "', '" + atten.OutTime + "','" + atten.HoursWorked + "')");

                // }
                // catch (Exception)
                //  {
                // MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // }
            }
            else
            {
                MessageBox.Show("There is another record with the same date!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader1021.Close();

            }
        }

        public static string addJobPerformance(JobPerformance jobPerformanceObj)
        {
            try
            {
                int x = existsRecordsJP(jobPerformanceObj);

                if(x == 1)
                {
                    DialogResult res = MessageBox.Show("There exists a record for the specified date, would you like to update it", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {

                        Database.updateJobPerformance(jobPerformanceObj);
                        return "Record Updated!";
                    }
                    if (res == DialogResult.Cancel)
                    {
                        return "Operation Cancelled";
                    }
                }

                if (x == 0) {
                    DBConnection.updateDB("insert into job_performance(staff_id, perf_year, knowledge, saftey, quality, adaptability, productivity, Initiative)values" +
                        "('" + jobPerformanceObj.StaffId + "','" + jobPerformanceObj.PerfYear.ToString("yyyy/M/d") + "', '" + jobPerformanceObj.Knowledge + "', '" + jobPerformanceObj.Safety + "'," +
                        "'" + jobPerformanceObj.Quality + "','" + jobPerformanceObj.Adaptability + "','" + jobPerformanceObj.Productivity + "','" + jobPerformanceObj.Initiative + "')");
                    return "Record added!";
                }
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!'" + ex + "'", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public static void updateJobPerformance(JobPerformance jobPerformanceObj)//This update does not work
        {
            try
            {
                DBConnection.updateDB("update job_performance set knowledge = '" + jobPerformanceObj.Knowledge + "'," +
                    "saftey = '" + jobPerformanceObj.Safety + "'," +
                    "quality =  '" + jobPerformanceObj.Quality + "'," +
                    "adaptability = '" + jobPerformanceObj.Adaptability + "'," +
                    "productivity = '" + jobPerformanceObj.Productivity + "'," +
                    "Initiative = '" + jobPerformanceObj.Initiative + "'" +
                    "where perf_year = '" + jobPerformanceObj.PerfYear.ToString("yyyy/M/d") + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!'" + ex + "'", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string addClientRelations(ClientRelations clientRelationsObj)
        {

            try
            {

            int x = existsRecordsCR(clientRelationsObj);
            if (x == 1) {
                DialogResult res = MessageBox.Show("There exists a record for the specified date, would you like to update it", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {

                    Database.updateClientRelations(clientRelationsObj);
                    return "Record Updated!";
                }
                if (res == DialogResult.Cancel)
                {
                    return "Operation Cancelled";
                }
            }
                if (x == 0) {
                    DBConnection.updateDB("insert into client_relations(staff_id, rel_year, telephone_skills, problem_resolution, salesmanship, pro_activeness, politeness)values('" + clientRelationsObj.StaffId + "','" + clientRelationsObj.RelYear.ToString("yyyy/M/d") + "', '" + clientRelationsObj.TelephoneSkills + "', '" + clientRelationsObj.ProblemResolution + "','" + clientRelationsObj.Salesmanship + "','" + clientRelationsObj.ProActiveness + "','" + clientRelationsObj.Politeness + "')");
                    return "New Record Added!";
                }
                return "";
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

        }

        public static void updateClientRelations(ClientRelations clientRelationsObj)
        {

            try
            {

                DBConnection.updateDB("update client_relations set" +
                    " telephone_skills = '" + clientRelationsObj.TelephoneSkills + "'," +
                    " problem_resolution = '" + clientRelationsObj.ProblemResolution + "', salesmanship = '" + clientRelationsObj.Salesmanship + "'," +
                    " pro_activeness = '" + clientRelationsObj.ProActiveness + "', politeness = '" + clientRelationsObj.Politeness + "' where rel_year = '" + clientRelationsObj.RelYear.ToString("yyyy/M/d") + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! + '" + ex + "'", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static string addCommunicationSkills(CommunicationSkills communicationSkillsObj)
        {
            
            try
            {
                
                int x = existsRecordsCS(communicationSkillsObj);
               
                if (x == 1) {                
                    DialogResult res = MessageBox.Show("There exists a record for the specified date, would you like to update it", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                       
                        Database.updateCommunicationSkills(communicationSkillsObj);
                        return "Record Updated!";
                    }
                    if (res == DialogResult.Cancel)
                    {
                        return "Operation Cancelled";
                    }
                    
                 }
               
                if (x == 0)
                {
                    DBConnection.updateDB("insert into communication_skills(staff_id, comm_year, influence, presentation, relationship, listening, negotiation)values('" + communicationSkillsObj.StaffId + "','" + communicationSkillsObj.CommYear.ToString("y/M/d") + "', '" + communicationSkillsObj.Influence + "', '" + communicationSkillsObj.Presentation + "','" + communicationSkillsObj.Relationships + "','" + communicationSkillsObj.Listening + "','" + communicationSkillsObj.Negotiation + "')");
                    return "Record added!";
                }
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrongYAYA! +'" + ex + "' ", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

        }

        public static int existsRecordsCS(CommunicationSkills communicationSkillsObj) {
            MySqlDataReader reader = DBConnection.getData("select * from communication_skills where staff_id = " + communicationSkillsObj.StaffId + " and comm_year = '" + communicationSkillsObj.CommYear.ToString("y/M/d") + "'");
            if (reader.HasRows)
            {
                reader.Close();
                return 1;
               
            }
            reader.Close();
            return 0;
        }

        public static int existsRecordsJP(JobPerformance jobPerformanceObj)
        {
            MySqlDataReader reader = DBConnection.getData("select * from job_performance where staff_id = " + jobPerformanceObj.StaffId + " and perf_year = '" + jobPerformanceObj.PerfYear.ToString("y/M/d") + "'");
            if (reader.HasRows)
            {
                reader.Close();
                return 1;

            }
            reader.Close();
            return 0;
        }

        public static int existsRecordsCR(ClientRelations clientRelations)
        {
            MySqlDataReader reader = DBConnection.getData("select * from client_relations where staff_id = " + clientRelations.StaffId + " and rel_year = '" + clientRelations.RelYear.ToString("y/M/d") + "'");
            if (reader.HasRows)
            {
                reader.Close();
                return 1;

            }
            reader.Close();
            return 0;
        }

        public static int existsRecordsIS(InterpersonalSkills interpersonalSkills)
        {
            MySqlDataReader reader = DBConnection.getData("select * from interpersonal_skills where staff_id = " + interpersonalSkills.StaffId + " and inter_year = '" + interpersonalSkills.InterYear.ToString("y/M/d") + "'");
            if (reader.HasRows)
            {
                reader.Close();
                return 1;

            }
            reader.Close();
            return 0;
        }

        public static void updateCommunicationSkills(CommunicationSkills communicationSkillsObj)//This update works
        {

            try
            {

                DBConnection.updateDB("update communication_skills set influence = '" + communicationSkillsObj.Influence + "', presentation = '" + communicationSkillsObj.Presentation + "', relationship = '" + communicationSkillsObj.Relationships + "' , listening = '" + communicationSkillsObj.Listening + "', negotiation = '" + communicationSkillsObj.Negotiation + "' where comm_year = '" + communicationSkillsObj.CommYear.ToString("yyyy/M/d") + "'");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrongYAYA! +'" + ex + "' ", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public static string addInterpersonalSkills(InterpersonalSkills interpersonalSkillsObj)
        {

            try
            {
                int x = existsRecordsIS(interpersonalSkillsObj);

                if (x == 1) {

                    DialogResult res = MessageBox.Show("There exists a record for the specified date, would you like to update it", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {

                        Database.updateInterpersonalSkills(interpersonalSkillsObj);
                        return "Record Updated!";
                    }
                    if (res == DialogResult.Cancel)
                    {
                        return "Operation Cancelled";
                    }

                }

                if (x == 0) {
                    DBConnection.updateDB("insert into interpersonal_skills(staff_id, inter_year, interaction_with_customers, interaction_with_supervisors, interaction_with_clients, motivational_skills, leadership)values('" + interpersonalSkillsObj.StaffId + "','" + interpersonalSkillsObj.InterYear.ToString("yyyy/M/d") + "', '" + interpersonalSkillsObj.InteractionWithCoworkers + "', '" + interpersonalSkillsObj.InteractionWithSupervisors + "','" + interpersonalSkillsObj.InteractionWithClients + "','" + interpersonalSkillsObj.MotivationalSkills + "','" + interpersonalSkillsObj.Leadership + "')");
                    return "Record added!";
                }
                return "";
                
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }


        public static void updateInterpersonalSkills(InterpersonalSkills interpersonalSkillsObj)
        {

            try
            {

                DBConnection.updateDB("update interpersonal_skills set interaction_with_customers ='" + interpersonalSkillsObj.InteractionWithCoworkers + "' , interaction_with_supervisors = '" + interpersonalSkillsObj.InteractionWithSupervisors + "', interaction_with_clients = '" + interpersonalSkillsObj.InteractionWithClients + "', motivational_skills = '" + interpersonalSkillsObj.MotivationalSkills + "', leadership = '" + interpersonalSkillsObj.Leadership + "' where inter_year = '" + interpersonalSkillsObj.InterYear.ToString("yyyy/M/d") + "'");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addProjectShortcomings(ProjectShortcomings projectShortcomings)
        {

            try
            {

                DBConnection.updateDB("insert into project_shortcomings(staff_id,proj_id,event_id,description)values('" + projectShortcomings.StaffId + "','" + projectShortcomings.ProjectId + "','" + projectShortcomings.EventId + "','" + projectShortcomings.Description + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void updateProjectShortcomings(ProjectShortcomings projectShortcomings)
        {

            try
            {

                DBConnection.updateDB("update project_shortcomings set description = '" + projectShortcomings.Description + "' where staff_id = '" + projectShortcomings.StaffId + "' and proj_id = '" + projectShortcomings.ProjectId + "' and event_id = '" + projectShortcomings.EventId + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! '" + ex + "'", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void deleteProjectShortcomings(ProjectShortcomings projectShortcomings)
        {

            try
            {

                DBConnection.updateDB("delete from project_shortcomings where staff_id = '" + projectShortcomings.StaffId + "' and proj_id = '" + projectShortcomings.ProjectId + "' and event_id = '" + projectShortcomings.EventId + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! '" + ex + "'", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void updateRecord(Attendance atten)
        {
            try
            {

                DBConnection.updateDB("update attendance set out_time = '" + atten.OutTime + "',total_hours = " + atten.HoursWorked + " where staff_id = " + atten.EmployeeNo + " and in_time = '" + atten.InTime + "'");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! + " + ex + "", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addStaff(Staff staff)
        {
            try
            {
                DBConnection.updateDB("insert into staff(first_name, last_name, " +
                    "nic, p_address, s_address, tel1, tel2, email, facebook, linkedin, basic_salary, ot_rate, desig_id) " +
                    "values('" + staff.FirstName + "','" + staff.LastName + "','" + staff.Nic + "'," +
                    "'" + staff.PAddress + "','" + staff.SAddress + "','" + staff.TelNumber[0] + "'," +
                    "'" + staff.TelNumber[1] + "'," +
                    "'" + staff.Email + "','" + staff.Facebook + "','" + staff.LinkedIn + "'," +
                    "" + staff.BasicSalary + "," + staff.OtRate + "," + staff.Designation.DesigId + ")");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong!\n" + exc, "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Adding a new schedule
        public static Boolean addSchedule(Schedule schedule)
        {
            try
            {
                DBConnection.updateDB("insert into schedule (proj_id, visit_type_id, to_date_time, from_date_time, to_do_list, resource, check_list, travelling_mode, accommodation, meals, logs) " +
                    "VALUES (" + schedule.ProjectOfSchedule.ProjectID + ", " + schedule.Type.EventTypeId + ", '" + schedule.To.ToString("yyyy-MM-dd HH:mm:ss") + "', '" +
                    schedule.From.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + schedule.TodoList + "', " +
                    "'" + schedule.Resource + "', '" + schedule.Checklist + "', '" + schedule.TravelMode + "'," +
                    " '" + schedule.AccommodationMode + "', '" + schedule.Meals + "', '" + schedule.Logs + "'); ");

                foreach (var ary in schedule.ServEngineer)
                {
                    Staff s = (Staff)ary;

                    DBConnection.updateDB("insert into schedule_technicians(sch_no, staff_id, proj_id) values (" + schedule.ScheduleId + ", " + s.StaffId + ", " + schedule.ProjectOfSchedule.ProjectID + ")");
                }

                foreach (var ary in schedule.ResoArray)
                {
                    Resource r = (Resource)ary;

                    DBConnection.updateDB("insert into schedule_resources(sch_no, proj_id, resource_id, qty) values (" + schedule.ScheduleId + ", " + schedule.ProjectOfSchedule.ProjectID + ", " + r.ResourceId + ", " + r.TotalQty + ")");
                }

                return true;

            }
            catch (Exception e)
            {

                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Add Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public static Boolean deleteSchedule(Schedule schedule)
        {
            try
            {
                DBConnection.updateDB("delete from schedule where proj_id = " + schedule.ProjectOfSchedule.ProjectID + " and sch_no = " + schedule.ScheduleId + ";");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        //adding service eng
        public static Boolean addServiceEngineer(Schedule schedule, int staff_id)
        {
            try
            {
                DBConnection.updateDB("insert into schedule_technicians (proj_id, sch_no, staff_id ) values (" + schedule.ProjectOfSchedule.ProjectID + "," + schedule.ScheduleId + ", " + staff_id + ");");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        //removing service eng
        public static Boolean deleteServiceEngineer(Schedule schedule, int staff_id)
        {
            try
            {
                DBConnection.updateDB("delete from schedule_technicians where proj_id = " + schedule.ProjectOfSchedule.ProjectID + " and sch_no = " + schedule.ScheduleId + " and staff_id = " + staff_id + ";");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        //update reso
        public static Boolean updateSchResource(Schedule schedule, Resource reso)
        {
            try
            {
                DBConnection.updateDB("update schedule_resources set qty = " + reso.TotalQty + " where proj_id = " + schedule.ProjectOfSchedule.ProjectID + " and sch_no = " + schedule.ScheduleId + " and resource_id = " + reso.ResourceId + ";");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //add reso
        public static Boolean addSchResource(Schedule schedule, Resource reso)
        {
            try
            {
                DBConnection.updateDB("insert into schedule_resources(sch_no, proj_id, resource_id, qty) values (" + schedule.ScheduleId + ", " + schedule.ProjectOfSchedule.ProjectID + ", " + reso.ResourceId + ", " + reso.TotalQty + ");");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //remove reso (update)
        public static Boolean removeSchResource(Schedule schedule, int reso_id)
        {
            try
            {
                DBConnection.updateDB("delete from schedule_resources where proj_id = " + schedule.ProjectOfSchedule.ProjectID + " and sch_no = " + schedule.ScheduleId + " and resource_id = " + reso_id + ";");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static Boolean updateSchedule(Schedule schedule)
        {
            try
            {

                DBConnection.updateDB("update schedule set visit_type_id = " + schedule.Type.EventTypeId + ", to_date_time = '" + schedule.To.ToString("yyyy-MM-dd HH:mm:ss") +
                    "', from_date_time ='" + schedule.From.ToString("yyyy-MM-dd HH:mm:ss") + "', to_do_list = '" + schedule.TodoList + "', resource = " +
                    "'" + schedule.Resource + "', check_list = '" + schedule.Checklist + "', travelling_mode = '" + schedule.TravelMode + "'," +
                    " accommodation = '" + schedule.AccommodationMode + "', meals = '" + schedule.Meals + "', logs = '" + schedule.Logs + "' where proj_id = "
                    + schedule.ProjectOfSchedule.ProjectID + " and sch_no = " + schedule.ScheduleId + ";");

                return true;

            }
            catch (Exception e)
            {

                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Add Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public static void addResource(Resource resource)
        {
            try
            {
                DBConnection.updateDB("insert into resource(name, value, total_qty, available_qty) " +
                    "values('" + resource.Name + "', '" + resource.Value + "','" + resource.TotalQty + "'" +
                    ",'" + resource.AvailableQty + "')");
            }

            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Add Resource", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Boolean deleteResource(Resource resource)
        {
            try
            {
                DBConnection.updateDB("delete from resource where resource_id = " + resource.ResourceId + ";");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Resource Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public static void updateResource(Resource resource)
        {
            try
            {

                DBConnection.updateDB("update resource set name = '" + resource.Name + "', value = " + resource.Value + ", " +
                    " total_qty = " + resource.TotalQty + ", available_qty = " + resource.AvailableQty + " where resource_id=" + resource.ResourceId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! '" + ex + "'", "Update resource", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Requesting admin permission

        public static void addNotification(UserNotification notification)
        {
            try
            {
                DBConnection.updateDB("insert into notification(user_id, function_id, statues, main_id, sub_id) " +
                    "values(" + notification.UserId + ", " + notification.FuctionId + ", " + notification.Status + ", " + notification.MainId + ", " + notification.SubId + ")");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong!\n" + exp, "Saving Request permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Granting permission
        public static void grantPermission(UserNotification notifi)
        {
            try
            {
                DBConnection.updateDB("UPDATE notification SET statues =" + notifi.Status + ", perm_by_id=" + Userglobals.uid + ", admin_view=1 WHERE noti_ID=" + notifi.NotiId + "");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        public static void addDesignation(Designation designation)
        {
            try
            {
                DBConnection.updateDB("insert into designation(designation_name) values('" + designation.DesignationName + "')");
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        public static void saveChangeRequest(ProjectRequest req)
        {
            try
            {
                DBConnection.updateDB("insert into proj_request (proj_id, request, added_date, urgent) " +
                    "values (" + req.ProjectOfRequest.ProjectID + ", '" + req.Request + "', '" + req.AddedDate.ToString("yyyy/MM/d HH:mm:ss") + "', " + req.Urgent + ")");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong!\n" + exc, "Add Change Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Boolean addEvent(Event evnt)
        {
            try
            {
                DBConnection.updateDB("insert into event (proj_id, visit_type_id, to_date_time, from_date_time, sch_no, feedback, Other, to_do_list, resource, check_list, travelling_mode, accommodation_mode, meals) " +
                    " values (" + evnt.EventProject.ProjectID + ", " + evnt.Type.EventTypeId + ", '" + evnt.To.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + evnt.From.ToString("yyyy-MM-dd HH:mm:ss") +
                    "', " + evnt.ScheduleId.ScheduleId + ", '" + evnt.Feedback + "', '" + evnt.Other + "', '" + evnt.TodoList + "', '" + evnt.Resource + "', '" + evnt.Checklist + "', '" + evnt.TravelMode + "', '" +
                    evnt.AccommodationMode + "', '" + evnt.Meals + "' )");

                foreach (var ary in evnt.ServEngineer)
                {
                    EventTechnician et = (EventTechnician)ary;

                    DBConnection.updateDB("insert into event_technicians (event_id, staff_id, feedback, proj_id, sch_no) values (" + et.EventOfTechnician.EventId + ", " + et.Technician.StaffId +
                        ", '" + et.Feedback + "', " + evnt.EventProject.ProjectID + ", " + evnt.ScheduleId.ScheduleId + ");");

                    MySqlDataReader reader = DBConnection.getData("select event_staff_id from event_technicians where staff_id = " + et.Technician.StaffId + " and event_id = " + et.EventOfTechnician.EventId +
                        " and proj_id = " + evnt.EventProject.ProjectID + " and sch_no = " + evnt.ScheduleId.ScheduleId + ";");

                    if (reader.Read())
                    {
                        int esi = reader.GetInt16("event_staff_id");
                        reader.Close();

                        DBConnection.updateDB("insert into event_technician_task (event_tech_id, task, man_hours) values (" + esi + ", '" + et.Task + "', " + et.ManHours + ");");
                    }

                }

                foreach (var ary in evnt.ResoArray)
                {
                    Resource r = (Resource)ary;

                    DBConnection.updateDB("insert into event_resources(event_id, sch_no, proj_id, resource_id, qty) values (" + evnt.EventId + "," + evnt.ScheduleId.ScheduleId + ", " + evnt.EventProject.ProjectID + ", " + r.ResourceId + ", " + r.TotalQty + ")");
                }

                return true;

            }
            catch (Exception e)
            {

                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Add Event", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public static Boolean deleteEvent(Event evnt)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select event_staff_id from event_technicians where event_id = " + evnt.EventId + " and proj_id = " + evnt.EventProject.ProjectID + " and sch_no = " + evnt.ScheduleId.ScheduleId + ";");

                while (reader.Read())
                {
                    DBConnection.updateDB("delete from event_technician_task where event_tech_id = " + reader.GetInt16("event_staff_id") + ";");
                }

                reader.Close();

                DBConnection.updateDB("delete from event_technicians where event_id = " + evnt.EventId + " and proj_id = " + evnt.EventProject.ProjectID + " and sch_no = " + evnt.ScheduleId.ScheduleId + ";");

                DBConnection.updateDB("delete from event where event_id = " + evnt.EventId + " and proj_id = " + evnt.EventProject.ProjectID + " and sch_no = " + evnt.ScheduleId.ScheduleId + ";");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public static void saveClientRequest(ClientRequest req)
        {
            try
            {
                DBConnection.updateDB("insert into client_request (client_id, request, added_date, importance) " +
                    "values (" + req.ReqClient.ClientID + ", '" + req.Request + "', '" + req.AddedDate.ToString("yyyy/MM/d HH:mm:ss") + "', " + req.Importance + ")");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong!\n" + exc, "Add Change Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public static void updateStaff(Staff staff)
        {
            try
            {

                DBConnection.updateDB("update staff set first_name = '" + staff.FirstName + "', last_name = '" + staff.LastName + "', " +
                    "nic = '" + staff.Nic + "', p_address = '" + staff.PAddress + "', s_address = '" + staff.SAddress + "', tel1 = '" + staff.TelNumber[0] + "'" +
                    ", tel2 = '" + staff.TelNumber[1] + "', email = '" + staff.Email + "', facebook = '" + staff.Facebook + "', linkedin = '" + staff.LinkedIn + "'" +
                    ", basic_salary = " + staff.BasicSalary + ", ot_rate = " + staff.OtRate + ", desig_id = " + staff.Designation.DesigId + " where staff_id=" + staff.StaffId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! '" + ex + "'", "Update staff member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void saveOfficeExpenses(Role.OfficeExpenses exp)
        {
            try
            {
                DBConnection.updateDB("insert into exp (staff_id, date, category,amount)" +
                                    +exp.StaffIssued.StaffId + "', '" + exp.Date + "', " +
                                      "'" + exp.Category + "', '" + exp.Amount + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Add client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addOfficeExp(Role.OfficeExpenses exp)
        {

             try
            {
            String date = DateTime.Now.ToString("yyyy-MM-dd");

            String type = exp.ExpType;
            int exid = exp.OffExpenseId;
            int staff = exp.StaffIssued.StaffId;
            String cat = exp.Category;
            double am = exp.Amount;


            DBConnection.updateDB("Insert into office_expenses (type, staff_id, date, Category, amount) values('" + type + "' , " + staff + " , '" + date + "' , '" + cat + "' , " + am + ");");

            MessageBox.Show("Successfully added to Office Expenses", "Add Expenses", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

                catch (Exception)
                {
                    MessageBox.Show("Something went wrong!","Add Expenses",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
        }

        public static void addIou(OfficeIou i)
        {

            //try
            //{

            int iou = i.IouNo;
            int staffId = i.ToStaff.StaffId;
            String comment = i.Comment;
            double am = i.Amount;


            DBConnection.updateDB("Insert into iou_office(staff_id,date,Comment,Amount)values(" + staffId + " , '" + DateTime.Now.ToString("yyyy/MM/d") + "', '" + comment + "' , " + am + ");");
            MessageBox.Show("Successfully added");

        }

        //  catch (Exception)
        //{
        //MessageBox.Show("Something went wrong!", "Add Expenses", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //}


        /*public static void updateOfficeExpense(OfficeExpenses exp)
        {
            try
            {
                DBConnection.updateDB("update client set name='" ( staff_id, date, category, amount)" +
                                      " values (" + exp.StaffIssued.StaffId + "', '" + exp.Date + "', " +
                                      "'" + exp.Category + "', '" + exp.Amount + "')");

            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */
        public static void addSalary(Role.Salary s)
        {

            try
            {


                DBConnection.updateDB("Insert into Salary(staff_id, basic_sal_amount, allowance, etf_epf_amount, rate, hours, gross_sal, net_sal) " +
                    "values" + "( " + s.Empid + " , " + s.BasicSalAmount + ", " + s.Allowance + " , " + s.EtfEpf + ", " + s.Rate + ", " + s.Hours.HoursWorked + ", " + s.Gross + ", " + s.Net + " );");
                  MessageBox.Show("Successfully recorded", "Successfull",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public static void updateSalary(Role.Salary s)
        {
            DBConnection.updateDB("Update Salary set basic_sal_amount = " + s.BasicSalAmount + ", rate = " + s.Rate + ", hours = " + s.Hours.HoursWorked + ", allowance = " + s.Allowance + ", gross_sal = " + s.Gross + ", etf_epf_amount = " + s.EtfEpf + ", net_sal = " + s.Net + " " +
                 " where staff_id = " + s.Empid + "");
            MessageBox.Show("Successfully added");
        }

        //update event
        public static Boolean updateEvent(Event evnt)
        {
            try
            {
                DBConnection.updateDB("update event set visit_type_id = " + evnt.Type.EventTypeId + " , to_date_time = '" + evnt.To.ToString("yyyy-MM-dd HH:mm:ss") + "' , from_date_time = '" + evnt.From.ToString("yyyy-MM-dd HH:mm:ss") + "' , sch_no = " + evnt.ScheduleId.ScheduleId + " , feedback = '" + evnt.Feedback + "' , Other = '" + evnt.Other + "' , to_do_list = '" + evnt.TodoList + "' , resource = '" + evnt.Resource + "' , check_list = '" + evnt.Checklist + "', travelling_mode = '" + evnt.TravelMode + "' , accommodation_mode = '" + evnt.AccommodationMode + "', meals = '" + evnt.Meals + "' where event_id = " + evnt.EventId + " and proj_id = " + evnt.EventProject.ProjectID + " and sch_no = " + evnt.ScheduleId.ScheduleId + ";");

                foreach (var item in evnt.ServEngineer)
                {
                    EventTechnician et = (EventTechnician)item;

                    DBConnection.updateDB("update event_technicians set event_id = " + evnt.EventId + ", staff_id = " + et.Technician.StaffId + ", feedback = '" + et.Feedback + "', proj_id = " + evnt.EventProject.ProjectID + ", sch_no = " + evnt.ScheduleId.ScheduleId + " where event_id = " + evnt.EventId + " and proj_id = " + evnt.EventProject.ProjectID + " and sch_no = " + evnt.ScheduleId.ScheduleId + "; ");

                    MySqlDataReader reader = DBConnection.getData("select event_staff_id from event_technicians where event_id = " + evnt.EventId + " and proj_id = " + evnt.EventProject.ProjectID + " and sch_no = " + evnt.ScheduleId.ScheduleId + ";");

                    if (reader.Read())
                    {
                        int esi = reader.GetInt16("event_staff_id");
                        reader.Close();

                        DBConnection.updateDB("update event_technician_task set task = '" + et.Task + "' where event_tech_id = " + esi + ";");

                    }
                    else
                    {
                        reader.Close();
                    }

                }

                return true;

            }
            catch (Exception e)
            {

                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Update Event", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public static void startCodingChangeRequest(ProjectRequest req)
        {
            int projId = req.ProjectOfRequest.ProjectID;
            int reqId = req.ReqId;
            int uid = req.StaffOfRequest.StaffId;

            try
            {
                DBConnection.updateDB("update proj_request set started_dateTime='" + DateTime.Now.ToString("yyyy/MM/d HH:mm:ss") + "', staff_id=" + uid + " where proj_id=" + projId + " and req_id=" + reqId);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong!", "Start coding change requests", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool endCodingChangeRequest(ProjectRequest req)
        {
            int projId = req.ProjectOfRequest.ProjectID;
            int reqId = req.ReqId;
            int uid = req.StaffOfRequest.StaffId;
            bool status = false;

            try
            {
                MySqlDataReader reader = DBConnection.getData("select staff_id from proj_request where proj_id=" + projId + " and req_id=" + reqId);

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        if (uid == reader.GetInt32(0))
                        {
                            reader.Close();

                            DBConnection.updateDB("update proj_request set ended_dateTime='" + DateTime.Now.ToString("yyyy/MM/d HH:mm:ss") + "', state=1 where staff_id=" + uid + " and proj_id=" + projId + " and req_id=" + reqId);

                            status = true;
                        }
                        else
                        {
                            MessageBox.Show("Started developer should End the development!", "Develop Change Request", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }

                if (!reader.IsClosed)
                {
                    reader.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong!", "End coding change requests", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return status;
        }

        public static void markSeenReq(List<Int32> projIds, List<Int32> reqIds, int uid)
        {
            if ((projIds.Count > 0) && (reqIds.Count > 0) && uid > 0)
            {
                for (int i = 0; i < projIds.Count; i++)
                {
                    int projId = projIds[i];
                    int reqId = reqIds[i];

                    try
                    {
                        DBConnection.updateDB("insert into proj_req_seen (proj_id, req_id, staff_id) values " +
                                                "(" + projId + ", " + reqId + ", " + uid + ");");

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Something went wrong! " + projIds.Count + ", " + uid + " \n" + exc, "Marking seen requests", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public static void addEventExpense(ExpenseDetailEvent exp)
        {
            try
            {
                DBConnection.updateDB("insert into exp_detail_event (exp_type_id, event_id, proj_id, amount, comment, dateOfExp, paymentType) values " +
                                        "(" + exp.ExpType.ExpTypeId + ", " + exp.EventOfExp.EventId + ", " + exp.ProjectOfEvent.ProjectID + ", " + exp.Amount + ", " +
                                        "'" + exp.Comment + "', '" + exp.DateOfExp.ToString("yyyy/MM/d") + "', '" + exp.PaymentType + "');");

            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong!\n" + exc, "Add Event Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void IssueCash(Iou iou)
        {
            try
            {
                DBConnection.updateDB("insert into iou (proj_id, sch_no, date, amount, detail) values (" + iou.ProjectOfIou.ProjectID + ", " + iou.ScheduleOfIou.ScheduleId + ", " +
                    "'" + iou.Date.ToString("yyyy/MM/d") + "', " + iou.Amount + ", '" + iou.Detail + "');");

            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong!\n" + exc, "Cash Issueing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //update event reso
        public static Boolean updateEventResource(Event evnt, Resource reso)
        {
            try
            {
                DBConnection.updateDB("update event_resources set qty = " + reso.TotalQty + " where proj_id = " + evnt.EventProject.ProjectID + " and sch_no = " + evnt.ScheduleId.ScheduleId + " and resource_id = " + reso.ResourceId + ";");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //add evnt reso
        public static Boolean addEventResource(Event evnt, Resource reso)
        {
            try
            {
                DBConnection.updateDB("insert into event_resources(event_id, sch_no, proj_id, resource_id, qty) values (" + evnt.EventId + "," + evnt.ScheduleId.ScheduleId + ", " + evnt.EventProject.ProjectID + ", " + reso.ResourceId + ", " + reso.TotalQty + ");");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //remove event reso (update)
        public static Boolean removeEventResource(Event evnt, int reso_id)
        {
            try
            {
                DBConnection.updateDB("delete from event_resources where event_id = " + evnt.EventId + " and proj_id = " + evnt.EventProject.ProjectID + " and sch_no = " + evnt.ScheduleId.ScheduleId + " and resource_id = " + reso_id + ";");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void acceptResetPass(UserNotification notifi)
        {
            try
            {
                DBConnection.updateDB("UPDATE notification SET admin_view=1 WHERE noti_ID=" + notifi.NotiId + ";");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}