using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;

namespace eng_website.Login
{
    public partial class LoginPage : System.Web.UI.Page
    {
        SqlConnection baglantim = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            string goster = string.Format("select*from user_tbl where usr_ncknm='{0}'and sifre='{1}' ", ncknm_txtbx.Text, sifre_txtbx.Text);
            SqlDataAdapter sorgu = new SqlDataAdapter(goster, baglantim);
            DataTable tablo = new DataTable();
            sorgu.Fill(tablo);
            
            try
            {
                Session["user_id"] = tablo.Rows[0]["user_id"].ToString();
            }
            catch
            {
                
                Label2.Text = "Kullanıcı Adı ya da Şifreniz Hatalı";

            }
            Response.Redirect("a_p.aspx");

            baglantim.Close();
           
           
        }
    }
}