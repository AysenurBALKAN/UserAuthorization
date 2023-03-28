using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eng_website
{
    public partial class yetk_dznl : System.Web.UI.Page
    {
        SqlConnection baglantim3 = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        bool durum;
        protected void Page_Load(object sender, EventArgs e)
        {
            baglantim3.Open();
            string idUser = " ";
            idUser = Request.QueryString["user_id"];
            if (!Page.IsPostBack)
            {
                SqlCommand goster = new SqlCommand("select*from yetki_tbl ", baglantim3);
                chckbx_yetki.DataSource = goster.ExecuteReader();
                chckbx_yetki.DataTextField = "yetki";
                chckbx_yetki.DataValueField = "yetki_id";
                chckbx_yetki.DataBind();

            }
           
            kllnc_id_txtbx.Text = idUser.ToString();
            SqlCommand goster_usernck = new SqlCommand("select usr_ncknm from user_tbl where user_id=@veri", baglantim3);
            goster_usernck.Parameters.AddWithValue("@veri", idUser);
            SqlDataReader dr = goster_usernck.ExecuteReader();
            if (dr.Read())
            {
                kllnc_ad_txtbx.Text = dr["usr_ncknm"].ToString();
            }

            if (Page.IsPostBack == false)
            {
                SqlCommand cmdgetir = new SqlCommand("yetkilndr", baglantim3);

              

            }
            if (!Page.IsPostBack)
            {
                SqlCommand yetkiler = new SqlCommand();
                SqlDataAdapter sorgu = new SqlDataAdapter();
                DataTable dt = new DataTable();
                yetkiler = new SqlCommand("yetkilndr", baglantim3);
                yetkiler.Parameters.Add(new SqlParameter("@user_id", idUser));
                yetkiler.CommandType = CommandType.StoredProcedure;
                sorgu.SelectCommand = yetkiler;
                sorgu.Fill(dt);
                for (int i = 0; i < chckbx_yetki.Items.Count; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (chckbx_yetki.Items[i].Value == dt.Rows[j]["yetki_id"].ToString())
                    {
                        chckbx_yetki.Items[i].Selected = true;
                    }
                }
            }
            
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

            
            string idUser = " ";
            idUser = Request.QueryString["user_id"];
          
            List<int> liste = new List<int>();
            foreach (ListItem item in chckbx_yetki.Items)
            {
                if (!Page.IsPostBack)
                {

              
                if (item.Selected == true)
                {
                    liste.Add(int.Parse(item.Value));

                }
                }
            }
        

           
            foreach (ListItem item in chckbx_yetki.Items)
            {
                {
                    SqlCommand cmdekleid2 = new SqlCommand("SELECT user_id='" + idUser + "' ", baglantim3);
                    int id2 = Convert.ToInt32(cmdekleid2.ExecuteScalar());
                    List<int> listem2 = new List<int>();
                    List<int> listesil = new List<int>();
                    
                    foreach (ListItem item3 in chckbx_yetki.Items)
                    {
                       
                        if (item3.Selected == true)
                        {
                            listem2.Add(int.Parse(item3.Value));
                            foreach (int items4 in listem2)
                            {
                                SqlCommand komut = new SqlCommand("select yetki_id from yetkilndrm_tbl where user_id='" + id2 + "' and yetki_id='" + items4 + "'", baglantim3);
                                SqlDataReader dr = komut.ExecuteReader();
                                if (dr.Read())
                                {
                                    List<int> listemekleme = new List<int>();
                                    listemekleme.Add(items4);

                                }
                                else
                                {
                                    List<int> listemekle = new List<int>();
                                    listemekle.Add(items4);
                                    foreach (int items in listemekle)
                                    {
                                        SqlCommand cmdekleyetki = new SqlCommand("add_yetki", baglantim3);
                                        cmdekleyetki.CommandType = CommandType.StoredProcedure;
                                        cmdekleyetki.Parameters.AddWithValue("@user_id", id2);
                                        cmdekleyetki.Parameters.AddWithValue("@yetki_id", items);
                                        cmdekleyetki.ExecuteNonQuery();

                                    }

                                }
                            }
                        }
                        else
                        {
                            
                               
                                listesil.Add(int.Parse(item3.Value));
                                foreach (int items6 in listesil)
                                {

                                    SqlCommand komut2 = new SqlCommand("select yetki_id from yetkilndrm_tbl where user_id='" + id2 + "' and yetki_id='" + items6 + "'", baglantim3);
                                    SqlDataReader dr2 = komut2.ExecuteReader();
                                    List<int> listemekleme2 = new List<int>();
                                    if (dr2.Read())
                                    {

                                        listemekleme2.Add(items6);
                                        foreach (int items in listemekleme2)
                                        {
                                            SqlCommand cmdekleyetki = new SqlCommand("delete from yetkilndrm_tbl where user_id='" + id2 + "' and yetki_id='" + items6 + "'", baglantim3);
                                           
                                            cmdekleyetki.ExecuteNonQuery();

                                        }


                                    }
                                

                            }
                        }






                    }

                       


                    }
                }
            baglantim3.Close();
            Response.Redirect("/K_YE");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/K_YE");
        }
    }


      
        }
    


    
            
        
    

