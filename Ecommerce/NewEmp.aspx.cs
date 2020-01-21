using System;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;

namespace Ecommerce
{
    public partial class NewEmp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmpUsername"] == null)
            {

                Response.Redirect("EmpLogin.aspx");

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string conString = @"server =localhost; Uid=root; password = ; persistsecurityinfo = True; database =ecommproj; SslMode = none";
            string sql = "insert into emptab(EmpName, EmpContact, EmpEmail, EmpCity, EmpAddress, EmpDept, EmpLevel, EmpUsername, EmpPassword) values (@eN, @eC, @eE, @eCt, @eA, @eD, @eL, @eU, @eP)";

            string name = Request.Form.Get("textname");
            string add = Request.Form.Get("textadd");
            string phn = Request.Form.Get("textnum");
            string eml = Request.Form.Get("texteml");
            string cty = Request.Form.Get("textcit");
            string dep = Request.Form.Get("textdep");
            string lev = Request.Form.Get("textlev");
            string usr = Request.Form.Get("textuser");
            string passw = Request.Form.Get("textpass");




            if (passw != null)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conString);

                    MySqlCommand cmd = new MySqlCommand(sql, con);



                    cmd.Parameters.AddWithValue("@eN", name);
                    cmd.Parameters.AddWithValue("@eC", phn);
                    cmd.Parameters.AddWithValue("@eE", eml);
                    cmd.Parameters.AddWithValue("@eCt", cty);
                    cmd.Parameters.AddWithValue("@eA", add);
                    cmd.Parameters.AddWithValue("@eD", dep);
                    cmd.Parameters.AddWithValue("@eL", lev);
                    cmd.Parameters.AddWithValue("@eU", usr);
                    cmd.Parameters.AddWithValue("@eP", passw);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();

                    textname.Text = String.Empty;
                    textadd.Text = String.Empty;
                    textnum.Text = String.Empty;
                    texteml.Text = String.Empty;
                    textcit.Text = String.Empty;
                    textdep.Text = String.Empty;
                    textlev.Text = String.Empty;
                    textuser.Text = String.Empty;
                    textpass.Text = String.Empty;
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                lblmsg.Text = "Saved Employee Information";

            }
        }
    }
}