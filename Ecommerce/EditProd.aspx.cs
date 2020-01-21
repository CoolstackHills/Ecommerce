using System;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class EditProd : System.Web.UI.Page
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
                cmd = new MySqlCommand("Select ID, prodName, prodCat, prodPrice, prodQua from protab", con);
                con.Open();
                dt.Load(cmd.ExecuteReader());
                con.Close();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
                con.Close();
            }
            gv1.DataSource = dt;
            gv1.DataBind();
        }

        protected void lnkbutton_OnClick(object sender, EventArgs e)
        {
            int proid = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string mycon = "server =localhost; Uid=root; password =; persistsecurityinfo = True; database =ecommproj; SslMode = none";
            MySqlConnection con = new MySqlConnection(mycon);

            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from protab where ID='" + proid + "'";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            TextBox1.Text = dt2.Rows[0][1].ToString();
            TextBox2.Text = dt2.Rows[0][4].ToString();
            TextBox3.Text = dt2.Rows[0][5].ToString();
            TextBox4.Text = dt2.Rows[0][0].ToString();
            con.Close();


        }

        protected void delbutton_OnClick(object sender, EventArgs e)
        {
            int proid = Convert.ToInt32((sender as LinkButton).CommandArgument);
            string mycon = "server =localhost; Uid=root; password =; persistsecurityinfo = True; database =ecommproj; SslMode = none";
            MySqlConnection con = new MySqlConnection(mycon);

            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "delete from protab where ID='" + proid + "'";
            cmd2.ExecuteNonQuery();
            con.Close();
            Page_Load(sender, e);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mycon = "server =localhost; Uid=root; password =; persistsecurityinfo = True; database =ecommproj; SslMode = none";
            MySqlConnection con = new MySqlConnection(mycon);

            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "update protab set prodPrice='" + TextBox2.Text + "', prodQua='" + TextBox3.Text + "' where ID='" + TextBox4.Text + "'";
            cmd2.ExecuteNonQuery();
            con.Close();
            Page_Load(sender, e);
        }
    }
}