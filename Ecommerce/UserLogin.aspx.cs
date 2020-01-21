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
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewUser.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mycon = @"server =localhost; Uid=root; password = ; persistsecurityinfo = True; database =ecommproj; SslMode = none";
            MySqlConnection con = new MySqlConnection(mycon);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from custab where CustUsername='" + t1.Text + "' and CustPassword='" + t2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Session["CustUsername"] = dr["CustUsername"].ToString();
                Response.Redirect("Index.aspx");
            }


            con.Close();


            Label1.Text = "Invalid username or password";
        }
    }
}