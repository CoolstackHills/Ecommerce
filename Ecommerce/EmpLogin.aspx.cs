using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

namespace Ecommerce
{
    public partial class EmpLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mycon = @"server =localhost; Uid=root; password = ; persistsecurityinfo = True; database =ecommproj; SslMode = none";
            MySqlConnection con = new MySqlConnection(mycon);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from emptab where EmpUsername='" + t1.Text + "' and EmpPassword='" + t2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Session["EmpUsername"] = dr["EmpUsername"].ToString();
                Response.Redirect("EmpIndex.aspx");
            }


            con.Close();


            Label1.Text = "Invalid username or password";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            Label1.Text = "";
            Session.Clear();
        }
    }
}