using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System;

namespace Ecommerce
{
    public partial class ViewCart : System.Web.UI.Page
    {
        string s;
        string t;
        string[] a = new string[6];
        decimal tot;
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

            if (Request.Cookies["aa"] == null)
            {
                Response.Write("<script>alert('Your cart is empty, continue shopping');</script>");
                Response.Redirect("ProdProf.aspx");
            }

            else
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[7] { new DataColumn("prodname"), new DataColumn("prodcat"), new DataColumn("proddesc"), new DataColumn("prodprice"), new DataColumn("prodqua1"), new DataColumn("prodimg"), new DataColumn("id") });
                if (Request.Cookies["aa"] != null)
                {
                    s = Convert.ToString(Request.Cookies["aa"].Value);
                    string[] strArr = s.Split('|');
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        t = Convert.ToString(strArr[i].ToString());
                        string[] strArr1 = t.Split(',');

                        for (int j = 0; j < strArr1.Length; j++)
                        {
                            a[j] = strArr1[j].ToString();
                        }

                        dt.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), a[4].ToString(), a[5].ToString(), i.ToString());

                        //tot = tot + (Convert.ToInt32(a[3].ToString()) * Convert.ToInt32(a[4].ToString()));
                        tot = tot + (Convert.ToDecimal(a[3].ToString()) * Convert.ToInt32(a[4].ToString()));
                }
                }
                d1.DataSource = dt;
                d1.DataBind();

                li.Text = "TOTAL : "+tot.ToString();
            }
           
        }

    }
}