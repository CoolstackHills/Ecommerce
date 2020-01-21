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
    public partial class delcart : System.Web.UI.Page
    {
        string s;
        string t;
        string[] a = new string[6];
        int id;
        string prodname, prodcat, prodprice, proddesc, prodimg, prodqua1;
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"].ToString());

            DataTable dt = new DataTable();
            dt.Rows.Clear();
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
                }
            }
            dt.Rows.RemoveAt(id);

            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);

            foreach (DataRow dr in dt.Rows)
            {
                prodname = dr["prodname"].ToString();
        prodcat = dr["prodcat"].ToString();
        proddesc = dr["proddesc"].ToString();
        prodprice = dr["prodprice"].ToString();
        prodimg = dr["prodimg"].ToString();
                prodqua1 = dr["prodqua1"].ToString();
                count = count + 1;
                if (count == 1)
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
            Response.Redirect("ViewCart.aspx");
        }
    }
}