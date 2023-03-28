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
    public partial class admin : System.Web.UI.MasterPage
    {
        SqlConnection baglantim = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            baglantim.Open();
            if (Session["user_id"] != null)
            {
               
                string user_id = (Session["user_id"].ToString());
                //Label1.Text = user_id;
                string gstrmenu = string.Format("select yetki from yetki_tbl where yetki_id IN(select yetki_id from yetkilndrm_tbl where user_id='" + (Session["user_id"].ToString()) + "')");
                SqlDataAdapter sorgu = new SqlDataAdapter(gstrmenu, baglantim);
                DataTable tablo = new DataTable();
                sorgu.Fill(tablo);
                //string yetkim;
               
              //foreach (DataRow row in tablo.Rows)
              //  {
              //      foreach (DataColumn column in tablo.Columns)
              //      {
              //          yetkim = row["yetki"].ToString();
              //      }
              
              //  }
                //int rowsayısı = tablo.Rows.Count;
                //Label1.Text = rowsayısı.ToString();
                //if (tablo.Rows.Count != 0)
                //{
                //    DropDownList1.DataSource = tablo;
                //    DropDownList1.DataTextField = "yetki";
                //    DropDownList1.DataBind();
                //    //for (int i = 0; i < tablo.Rows.Count; i++)
                //    //{
                //    //    //Label2.Text += tablo.Rows[i]["yetki"].ToString();
                //    //    //Label1.Text += " | ";
                //    //    //Label2.Text = user_id;


                //    //}
                //}
                //else
                //{
                //    Response.Redirect("LoginPage.aspx");
                //}


            
                List<string> listeyetki = new List<string>();
                System.Data.DataSet ds = new System.Data.DataSet();
                ds.Tables.Add(tablo);
                string ids = "";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ids += ds.Tables[0].Rows[i]["yetki"].ToString();
                    //Label2.Text = ids;
                    listeyetki.Add(ids);
                }

                string gostermenu = string.Format("select yetki,link from yetki_tbl where yetki_id IN (select yetki_id from yetkilndrm_tbl where user_id='" + (Session["user_id"].ToString()) + "')");
                ////SqlCommand gostermenu = new SqlCommand("select yetki from yetki_tbl where yetki='"+ (Label1.Text).ToString()+'", baglantim);
                SqlDataAdapter sorgu2 = new SqlDataAdapter(gostermenu, baglantim);
                DataTable tablo2 = new DataTable();
                sorgu2.Fill(tablo2);
                    Repeater1.DataSource = tablo2;
                    Repeater1.DataBind();

                baglantim.Close();
            }
        }
        

            protected void Button1_Click(object sender, EventArgs e)
                {
                    Session.RemoveAll();
                    if (Session["user_id"] == null)
                    {
                        //Label1.Text = "session boş";
                        //Response.Redirect("LoginPage.aspx");
                    }

                }

            
        }
    }
