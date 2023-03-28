using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace eng_website.admin_panel
{
    public partial class AddUser : System.Web.UI.Page
    {
        SqlConnection baglantim = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttnsave_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            SqlCommand cmdekle2 = new SqlCommand("user_add", baglantim);
            cmdekle2.CommandType = CommandType.StoredProcedure;
            cmdekle2.Parameters.AddWithValue("@usr_ncknm ", usrtxtbx.Text);
            cmdekle2.Parameters.AddWithValue("@sifre", pswtxtbx.Text);
            cmdekle2.ExecuteNonQuery();
            baglantim.Close();
            info_lbl.Text = "Başarıyla kaydediledi";
            usrtxtbx.Text = " ";
            pswtxtbx.Text = " ";




        }
    }
}