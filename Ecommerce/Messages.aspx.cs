using System;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Messages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmpUsername"] == null)
            {

                Response.Redirect("EmpLogin.aspx");

            }
            string mycon = "server =localhost; Uid=root; password =; persistsecurityinfo = True; database =ecommproj; SslMode = none";
            MySqlConnection con = new MySqlConnection(mycon);
            DataTable dt = new DataTable();
            MySqlCommand cmd = null;
            try
            {
                cmd = new MySqlCommand("Select MessId, MessEmail, MessSubject, MessCont, MessDate, MessTime from messtab", con);
                con.Open();
                dt.Load(cmd.ExecuteReader());
                con.Close();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
                con.Close();
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void lnkbutton_OnClick(object sender, EventArgs e)
        {
            int messid = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string mycon = "server =localhost; Uid=root; password =; persistsecurityinfo = True; database =ecommproj; SslMode = none";
             MySqlConnection con = new MySqlConnection(mycon);
           
                con.Open();
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from messtab where MessId='" + messid + "'";
                cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            TextBox1.Text = dt2.Rows[0][1].ToString();
            TextBox2.Text = dt2.Rows[0][2].ToString();
            TextBox3.Text = dt2.Rows[0][3].ToString();
            con.Close();

        }

        protected void delbutton_OnClick(object sender, EventArgs e)
        {
            int messid = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string mycon = "server =localhost; Uid=root; password =; persistsecurityinfo = True; database =ecommproj; SslMode = none";
            MySqlConnection con = new MySqlConnection(mycon);

            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "delete from messtab where MessId='" + messid + "'";
            cmd2.ExecuteNonQuery();
            con.Close();
            Page_Load(sender, e);

        }
    }
}