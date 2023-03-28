using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace eng_website.admin_panel
{
    public partial class kullanici_yetki : System.Web.UI.Page
    {
        SqlConnection baglantim = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        string id_user = " ";
        string islem = " ";
        protected void Page_Load(object sender, EventArgs e)
        {
            baglantim.Open();

            id_user = Request.QueryString["user_id"];
            islem = Request.QueryString["islem"];
            if (islem == "sil")
            {
                SqlCommand blogSil = new SqlCommand(" Delete from user_tbl where user_id='" + id_user + "'", baglantim);
                blogSil.ExecuteNonQuery();
            }


            if (Page.IsPostBack == false)
            {
                SqlCommand goster = new SqlCommand("get_user", baglantim);
                Repeaterytk.DataSource = goster.ExecuteReader();
                Repeaterytk.DataBind();
            }
        }

    }
}