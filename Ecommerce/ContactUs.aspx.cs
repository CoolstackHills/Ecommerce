using System;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;

namespace Ecommerce
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["CustUsername"] == null)
            {

                sectprof.Visible = true;
                Section1.Visible = false;

            }
            else
            {
                {
                    sectprof.Visible = false;
                    Section1.Visible = true;
                    Label1.Text = Session["CustUsername"].ToString();
                }
               
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string conString = @"server =localhost; Uid=root; password = ; persistsecurityinfo = True; database =ecommproj; SslMode = none";
            string sql = "insert into messtab(MessEmail, MessSubject, MessCont, MessTime, MessDate) values (@mE, @mS, @mC, @t1, @d1)";

            string meml = Request.Form.Get("textemail");
            string msub = Request.Form.Get("textsubject");
            string mcont = Request.Form.Get("textmessage");



            if (mcont != null)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conString);

                    MySqlCommand cmd = new MySqlCommand(sql, con);



                    cmd.Parameters.AddWithValue("@mE", meml);
                    cmd.Parameters.AddWithValue("@mS", msub);
                    cmd.Parameters.AddWithValue("@mC", mcont);
                    cmd.Parameters.AddWithValue("@d1", DateTime.Today);
                    cmd.Parameters.AddWithValue("@t1", DateTime.Now);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();

                    textemail.Text = String.Empty;
                    textsubject.Text = String.Empty;
                    textmessage.Text = String.Empty;
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                lblmsg.Text = "Message Sent";

            }
        }
    }
}