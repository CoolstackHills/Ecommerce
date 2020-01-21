using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Ecommerce
{
    public partial class Index : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"server =localhost; Uid=root; password = ; persistsecurityinfo = True; database =ecommproj; SslMode = none");

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
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from protab";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            d1.DataSource = dt;
            d1.DataBind();
            con.Close();
        }

       }
}