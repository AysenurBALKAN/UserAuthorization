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
    public partial class admin_panel : System.Web.UI.Page
    {
        SqlConnection baglantim = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

            baglantim.Open();
            if (Session["user_id"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
           
            baglantim.Close();
        }

    }
    }
