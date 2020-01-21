using System;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;

namespace Ecommerce
{
    public partial class AddProd : System.Web.UI.Page
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
            string sql = "insert into protab(prodName, prodCat, prodDesc, prodPrice, prodQua, prodImgName, prodImgPath, PosTime, PosDate) values (@pN, @pC, @pD, @pP, @pQ, @pImgName, @pImgPath, @t1, @d1)";

            string name = Request.Form.Get("pName");
            string cat = Request.Form.Get("pCat");
            string des = Request.Form.Get("pDesc");
            string pric = Request.Form.Get("pPrice");
            string qty = Request.Form.Get("qAvail");




            if (FileUpload1.PostedFile != null)
            {
                try
                {
                    string prodImgName = Path.GetFileName(FileUpload1.PostedFile.FileName);

                    FileUpload1.SaveAs(Server.MapPath(@"~/ProdImg/" + prodImgName));

                    MySqlConnection con = new MySqlConnection(conString);

                    MySqlCommand cmd = new MySqlCommand(sql, con);



                    cmd.Parameters.AddWithValue("@pN", name);
                    cmd.Parameters.AddWithValue("@pC", cat);
                    cmd.Parameters.AddWithValue("@pD", des);
                    cmd.Parameters.AddWithValue("@pP", pric);
                    cmd.Parameters.AddWithValue("@pQ", qty);
                    cmd.Parameters.AddWithValue("@pImgName", prodImgName);
                    cmd.Parameters.AddWithValue("@pImgPath", "ProdImg/" + prodImgName);
                    cmd.Parameters.AddWithValue("@d1", DateTime.Today);
                    cmd.Parameters.AddWithValue("@t1", DateTime.Now);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();

                    pName.Text = String.Empty;
                    pCat.Text = String.Empty;
                    pDesc.Text = String.Empty;
                    pPrice.Text = String.Empty;
                    qAvail.Text = String.Empty;
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                lblmsg.Text = "Save Product Information";

            }
        }
    }
}