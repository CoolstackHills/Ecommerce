using System;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;

namespace Ecommerce
{
    public partial class NewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            string conString = @"server =localhost; Uid=root; password = ; persistsecurityinfo = True; database =ecommproj; SslMode = none";
            string sql = "insert into custab(CustFName, CustLName, CustEmail, CustContact, CustAdd, CustCity, CustState, CustUsername, CustPassword) values (@cFn, @cLn, @cE, @cN, @cA, @cC, @cS, @cU, @cP)";

            string fname = Request.Form.Get("textfname");
            string lname = Request.Form.Get("textlname");
            string eml = Request.Form.Get("textemail");
            string num = Request.Form.Get("textnum");
            string add = Request.Form.Get("textadd");
            string cty = Request.Form.Get("textcity");
            string stat = Request.Form.Get("textstate");
            string usr = Request.Form.Get("textuser");
            string passw = Request.Form.Get("textpass");




            if (passw != null)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conString);

                    MySqlCommand cmd = new MySqlCommand(sql, con);



                    cmd.Parameters.AddWithValue("@cFn", fname);
                    cmd.Parameters.AddWithValue("@cLn", lname);
                    cmd.Parameters.AddWithValue("@cE", eml);
                    cmd.Parameters.AddWithValue("@cN", num);
                    cmd.Parameters.AddWithValue("@cA", add);
                    cmd.Parameters.AddWithValue("@cC", cty);
                    cmd.Parameters.AddWithValue("@cS", stat);
                    cmd.Parameters.AddWithValue("@cU", usr);
                    cmd.Parameters.AddWithValue("@cP", passw);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();

                    textfname.Text = String.Empty;
                    textlname.Text = String.Empty;
                    textemail.Text = String.Empty;
                    textnum.Text = String.Empty;
                    textadd.Text = String.Empty;
                    textcity.Text = String.Empty;
                    textstate.Text = String.Empty;
                    textuser.Text = String.Empty;
                    textpass.Text = String.Empty;
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                lblmsg.Text = "Saved Customer Information";
                Response.Redirect("UserLogin.aspx");

            }
        }
    }
}