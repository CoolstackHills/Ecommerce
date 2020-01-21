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
    public partial class ProdProf : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"server =localhost; Uid=root; password = ; persistsecurityinfo = True; database =ecommproj; SslMode = none");
        int id, prodqua;
        string prodname, prodcat, prodprice, proddesc, prodimg;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("Index.aspx");
            }

            else
            {

                id = Convert.ToInt32(Request.QueryString["id"].ToString());
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ID, prodName, prodCat, prodDesc, prodPrice, prodImgPath from protab  where ID='" + id + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                d1.DataSource = dt;
                d1.DataBind();
                con.Close();
            }
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

        protected void b1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ID, prodName, prodCat, prodDesc, prodQua, prodPrice, prodImgPath from protab  where ID='" + id + "';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                prodname = dr["prodName"].ToString();
                prodcat = dr["prodCat"].ToString();
                proddesc = dr["prodDesc"].ToString();                
                prodprice = dr["prodPrice"].ToString();
                prodimg = dr["prodImgPath"].ToString();
            }
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                prodqua = reader.GetInt32("prodQua");
            }
            con.Close();

            
            if (Convert.ToInt32(t1.Text) > Convert.ToInt32(prodqua))
            {
                l1.Text = "Enter Lower Quantity";
                l2.Text = "Quantity Unavailable";
            }
            else
            {

              string prodqua1=  t1.Text;
            if (Request.Cookies["aa"] == null)
            {
                Response.Cookies["aa"].Value = prodname.ToString() + "," + prodcat.ToString() + "," + proddesc.ToString() + "," + prodprice.ToString() + "," + prodqua1.ToString() + "," + prodimg.ToString();
                Response.Cookies["aa"].Expires = DateTime.Now.AddHours(1);
            }

            else
            {
                Response.Cookies["aa"].Value = Request.Cookies["aa"].Value + "|" + prodname.ToString() + "," + prodcat.ToString() + "," + proddesc.ToString() + "," + prodprice.ToString() + "," + prodqua1.ToString() + "," + prodimg.ToString();
                Response.Cookies["aa"].Expires = DateTime.Now.AddHours(1);
            }
        }

        }

        protected void b2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCart.aspx");
        }
    }

    }